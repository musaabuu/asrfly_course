using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
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

namespace Asrfly.Gui.GuiCategories {
    public partial class AddCustomersForm : Form {
        private readonly int Id;
        private readonly CustomersUserControl categoryUserControl;
        private Categories categories;
        private readonly IDataHelper<Categories> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;

        public AddCustomersForm(int Id, CustomersUserControl categoryUserControl) {
            InitializeComponent();
            dataHelper = (IDataHelper<Categories>)ConfigurationObjectManager.GetObject("Categories");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.Id = Id;
            this.categoryUserControl = categoryUserControl;
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

        private async void AddCategoryForm_Load(object sender, EventArgs e) {
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
            if (textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty) {
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> AddData() {
            // Set Data 

            categories = new Categories {
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.AddAsync(categories);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية اضافة",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة صنف " + categories.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                categoryUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> EditData() {
            // Set Data 

            categories = new Categories {
                Id = Id,
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.EditAsync(categories);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية تعديل",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل الصنف " + categories.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                categoryUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async void SetFieldData() {
            if (Id > 0) {
                // Set Categories
                categories = await dataHelper.FindAsync(Id);
                if (categories != null) {
                    textBoxName.Text = categories.Name;
                    textBoxBalance.Text = categories.Balance.ToString();
                    richTextBoxDetails.Text = categories.Details;
                    comboBoxType.SelectedItem = categories.Type;
                } else {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        private void ClearFields() {
            textBoxName.Text = null;
            comboBoxType.SelectedItem = null;
            richTextBoxDetails.Text = null;
        }

        #endregion


    }
}
