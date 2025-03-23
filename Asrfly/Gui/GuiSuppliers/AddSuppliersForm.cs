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

namespace Asrfly.Gui.GuiSuppliers {
    public partial class AddSuppliersForm : Form {
        private readonly int Id;
        private readonly SuppliersUserControl suppliersUserControl;
        private Suppliers suppliers;
        private readonly IDataHelper<Suppliers> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;

        public AddSuppliersForm(int Id, SuppliersUserControl suppliersUserControl) {
            InitializeComponent();
            dataHelper = (IDataHelper<Suppliers>)ConfigurationObjectManager.GetObject("Suppliers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.Id = Id;
            this.suppliersUserControl = suppliersUserControl;
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

        private async void AddSuppliersForm_Load(object sender, EventArgs e) {
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

            suppliers = new Suppliers {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.AddAsync(suppliers);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية اضافة مورد",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة مورد " + suppliers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                suppliersUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> EditData() {
            // Set Data 

            suppliers = new Suppliers {
                Id = Id,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.EditAsync(suppliers);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية تعديل مورد",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل المورد " + suppliers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                suppliersUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async void SetFieldData() {
            if (Id > 0) {
                // Set Suppliers
                suppliers = await dataHelper.FindAsync(Id);
                if (suppliers != null) {
                    textBoxName.Text = suppliers.Name;
                    textBoxPhoneNumber.Text = suppliers.PhoneNumber;
                    textBoxAddress.Text = suppliers.Address;
                    textBoxEmail.Text = suppliers.Email;
                    textBoxBalance.Text = suppliers.Balance.ToString();
                    richTextBoxDetails.Text = suppliers.Details;
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
