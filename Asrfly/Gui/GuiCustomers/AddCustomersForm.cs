using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Asrfly.Gui.GuiCustomers {
    public partial class AddCustomersForm : Form {
        private readonly int Id;
        private readonly CustomersUserControl customersUserControl;
        private Customers customers;
        private readonly IDataHelper<Customers> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;

        public AddCustomersForm(int Id, CustomersUserControl customersUserControl) {
            InitializeComponent();
            dataHelper = (IDataHelper<Customers>)ConfigurationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.Id = Id;
            this.customersUserControl = customersUserControl;
        }

        private async void buttonSaveAndClose_Click(object sender, EventArgs e) {
            // Check If Fields Are Empty
            if (IsFieldEmpty()) {
                MessageCollections.ShowFieldsRequired();
            } else {
                loadingForm.Show();
                if (await SaveData()) {
                    if (Id == 0) {
                        MessageCollections.ShowAddNotification();
                    } else {
                        MessageCollections.ShowUpdateNotification();
                    }
                    Close();
                } else {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e) {
            // Check If Fields Are Empty
            if (IsFieldEmpty()) {
                MessageCollections.ShowFieldsRequired();
            } else {
                loadingForm.Show();
                if (await SaveData()) {
                    if (Id == 0) {
                        MessageCollections.ShowAddNotification();
                    } else {
                        MessageCollections.ShowUpdateNotification();
                    }
                } else {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
            ClearFields();
        }

        private async void AddCustomersForm_Load(object sender, EventArgs e) {
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
        }

        #region Methods

        private async Task<bool> SaveData() {
            // Add 
            if (Id == 0) {
                return await AddData();
            }
            // Edit
            else {
                return await EditData();
            }
        }

        private bool IsFieldEmpty() {
            if (textBoxName.Text == string.Empty) {
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> AddData() {
            // Set Data 

            customers = new Customers {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.AddAsync(customers);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية اضافة عميل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة عميل " + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                customersUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> EditData() {
            // Set Data 

            customers = new Customers {
                Id = Id,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.EditAsync(customers);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية تعديل عميل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل العميل " + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                customersUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async void SetFieldData() {
            if (Id > 0) {
                // Set Customers
                customers = await dataHelper.FindAsync(Id);
                if (customers != null) {
                    textBoxName.Text = customers.Name;
                    textBoxPhoneNumber.Text = customers.PhoneNumber;
                    textBoxAddress.Text = customers.Address;
                    textBoxEmail.Text = customers.Email;
                    textBoxBalance.Text = customers.Balance.ToString();
                    richTextBoxDetails.Text = customers.Details;
                } else {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        private void ClearFields() {
            textBoxName.Text = null;
            textBoxAddress.Text = null;
            textBoxPhoneNumber.Text = null;
            textBoxEmail.Text = null;
            richTextBoxDetails.Text = null;
        }

        #endregion


    }
}
