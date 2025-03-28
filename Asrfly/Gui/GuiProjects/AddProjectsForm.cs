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

namespace Asrfly.Gui.GuiProjects {
    public partial class AddProjectsForm : Form {
        private readonly int Id;
        private readonly ProjectsUserControl projectsUserControl;
        private Projects projects;
        private readonly IDataHelper<Projects> dataHelper;
        private readonly IDataHelper<Customers> dataHelperCustomers;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;

        public AddProjectsForm(int Id, ProjectsUserControl projectsUserControl) {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigurationObjectManager.GetObject("Projects");
            dataHelperCustomers = (IDataHelper<Customers>)ConfigurationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.Id = Id;
            this.projectsUserControl = projectsUserControl;
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

        private async void AddProjectsForm_Load(object sender, EventArgs e) {
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

            projects = new Projects {
                Name = textBoxName.Text,
                Customer = comboBoxCustomer.Text,
                Company = textBoxCompany.Text,
                StartDate = dateTimePickerStartDate.Value,
                FinishDate = dateTimePickerFinishDate.Value,
                Address = textBoxAddress.Text,
                Details = richTextBoxDetails.Text,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.AddAsync(projects);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية اضافة مشروع",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم اضافة مشروع " + projects.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                projectsUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async Task<bool> EditData() {
            // Set Data 

            projects = new Projects {
                Id = Id,
                Name = textBoxName.Text,
                Customer = comboBoxCustomer.Text,
                Company = textBoxCompany.Text,
                StartDate = dateTimePickerStartDate.Value,
                FinishDate = dateTimePickerFinishDate.Value,
                Address = textBoxAddress.Text,
                Details = richTextBoxDetails.Text,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                AddedDate = DateTime.Now,
            };

            // Submit Data

            var results = await dataHelper.EditAsync(projects);
            if (results == 1) {
                // Save System Records
                var systemReocrds = new SystemRecords {
                    Title = "عملية تعديل مشروع",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل المشروع " + projects.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemReocrds);
                projectsUserControl.LoadData();
                return true;
            } else {
                return false;
            }
        }

        private async void SetFieldData() {
            // Get List Of Customers
            var listCustomers = await dataHelperCustomers.GetAllDataAsync();
            comboBoxCustomer.DataSource = listCustomers.Select(x => x.Name).ToList();
            // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(listCustomers.Select(x => x.Name).ToArray());
            comboBoxCustomer.AutoCompleteCustomSource = autoCompleteStringCollection;
            listCustomers.Clear();
            if (Id > 0) {
                var projects = await dataHelper.FindAsync(Id);
                // Set Projects
                if (projects != null) {
                    textBoxName.Text = projects.Name;
                    textBoxAddress.Text = projects.Address;
                    richTextBoxDetails.Text = projects.Details;
                    textBoxName.Text = projects.Name;
                    comboBoxCustomer.Text = projects.Customer;
                    textBoxCompany.Text = projects.Company;
                    textBoxAddress.Text = projects.Address;
                    dateTimePickerStartDate.Value = projects.StartDate;
                    dateTimePickerFinishDate.Value = projects.FinishDate;
                    richTextBoxDetails.Text = projects.Details;
                    textBoxIncome.Text = projects.Income.ToString();
                    textBoxOutcome.Text = projects.Outcome.ToString();
                    textBoxRevenue.Text = projects.Revenue.ToString();
                } else {
                    MessageCollections.ShowErrorServer();
                }
            }
        }

        private void ClearFields() {
            textBoxName.Text = null;
            textBoxAddress.Text = null;
            textBoxCompany.Text = null;
            comboBoxCustomer = null;
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerFinishDate.Value = DateTime.Now;
            richTextBoxDetails.Text = null;
        }

        #endregion

    }
}
