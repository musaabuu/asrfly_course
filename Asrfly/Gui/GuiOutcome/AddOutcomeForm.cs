using Asrfly.Code;
using Asrfly.Core;
using Asrfly.Data;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.ExtendedProperties;
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

namespace Asrfly.Gui.GuiOutcome {
    public partial class AddOutcomeForm : Form {
        private readonly int Id;
        private readonly OutcomeUserControl outcomeUserControl;
        private Outcome outcome;
        private int CategoryId;
        private int SupplierId;
        private int ProjectId;
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<Suppliers> dataHelperSuppliers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;

        public AddOutcomeForm(int Id, int ProjectId, OutcomeUserControl outcomeUserControl) {
            InitializeComponent();
            dataHelper = (IDataHelper<Outcome>)ConfigurationObjectManager.GetObject("Outcome");
            dataHelperSuppliers = (IDataHelper<Suppliers>)ConfigurationObjectManager.GetObject("Suppliers");
            dataHelperCategories = (IDataHelper<Categories>)ConfigurationObjectManager.GetObject("Categories");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.Id = Id;
            this.outcomeUserControl = outcomeUserControl;
            this.ProjectId = ProjectId;
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

        private async void AddOutcomeForm_Load(object sender, EventArgs e) {
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
        }

        #region Methods

        private async Task<bool> SaveData() {
            // Add 

            if (Id == 0) {
                var CategoryName = comboBoxCategory.SelectedItem.ToString();
                var SupplierName = comboBoxSupplier.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));
                return await AddData();
            }
            // Edit
            else {
                var CategoryName = comboBoxCategory.SelectedItem.ToString();
                var SupplierName = comboBoxSupplier.SelectedItem.ToString();
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));
                return await EditData();
            }
        }

        private bool IsFieldEmpty() {
            if (comboBoxCategory.SelectedItem == null
            || comboBoxSupplier.SelectedItem == null
            || textBoxAmount.Text == string.Empty) {
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> AddData() {
            // Set Data 

            outcome = new Outcome {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxSupplier.SelectedItem.ToString(),
                ReceiveNumber = textBoxReceiveNumber.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };

            // Submit Data

            var results = await dataHelper.AddAsync(outcome);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "اضافة عملية صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة عملية صرف " + outcome.CategoryName,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                outcomeUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> EditData() {
            // Set Data 

            outcome = new Outcome {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxSupplier.SelectedItem.ToString(),
                ReceiveNumber = textBoxReceiveNumber.Text,
                Details = richTextBoxDetails.Text,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                OutcomeDate = dateTimePickerDate.Value,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };

            // Submit Data

            var results = await dataHelper.EditAsync(outcome);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "تعديل عملية صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل عملية صرف " + outcome.CategoryName,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                outcomeUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async void SetFieldData() {
            // Get List Of Suppliers
            var listSuppliers = await dataHelperSuppliers.GetAllDataAsync();
            comboBoxSupplier.DataSource = listSuppliers.Select(x => x.Name).ToList();
            // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(listSuppliers.Select(x => x.Name).ToArray());
            comboBoxSupplier.AutoCompleteCustomSource = autoCompleteStringCollection;
            listSuppliers.Clear();

            // Get List Of Categories
            var listCategories = await dataHelperCategories.GetAllDataAsync();
            comboBoxCategory.DataSource = listCategories.Select(x => x.Name).ToList();
            // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCollectionCategories = new AutoCompleteStringCollection();
            autoCompleteStringCollectionCategories.AddRange(listCategories.Select(x => x.Name).ToArray());
            comboBoxCategory.AutoCompleteCustomSource = autoCompleteStringCollectionCategories;
            listCategories.Clear();

            if (Id > 0) {
                // Set Outcome
                if (outcome != null) {
                    comboBoxCategory.SelectedItem = outcome.CategoryName;
                    comboBoxSupplier.SelectedItem = outcome.SupplierName;
                    textBoxReceiveNumber.Text = outcome.ReceiveNumber;
                    richTextBoxDetails.Text = outcome.Details;
                    textBoxAmount.Text = outcome.Amount.ToString();
                    dateTimePickerDate.Value = outcome.OutcomeDate;
                    CategoryId = outcome.CategoryId;
                    SupplierId = outcome.SupplierId;
                    ProjectId = outcome.ProjectId;
                } else {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        private void ClearFields() {
            comboBoxCategory = null;
            textBoxReceiveNumber = null;
            comboBoxSupplier = null;
            dateTimePickerDate.Value = DateTime.Now;
            richTextBoxDetails.Text = null;
            textBoxAmount = null;
        }
        private void SetCategoryId(string CategoryName) {
            CategoryId = dataHelperCategories.GetAllData().Where(x => x.Name == CategoryName).Select(x => x.Id).First();
        }
        
        private void SetSupplierId(string SupplierName) {
            SupplierId = dataHelperSuppliers.GetAllData().Where(x => x.Name == SupplierName).Select(x => x.Id).First();
        }

        #endregion

    }
}
