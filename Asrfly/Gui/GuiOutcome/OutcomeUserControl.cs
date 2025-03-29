using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asrfly.Data;
using Asrfly.Core;
using Asrfly.Code;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Presentation;

namespace Asrfly.Gui.GuiOutcome {
    public partial class OutcomeUserControl : UserControl {
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private static OutcomeUserControl _OutcomeUserControl;
        private int RowId;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private int ProjectId;

        public OutcomeUserControl(int ProjectId) {
            InitializeComponent();
            this.ProjectId = ProjectId;
            dataHelper = (IDataHelper<Outcome>)ConfigurationObjectManager.GetObject("Outcome");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            LoadData();
        }

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e) {
            AddOutcomeForm addOutcomeForm = new AddOutcomeForm(0, ProjectId, this);
            addOutcomeForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            Edit();
        }

        private async void buttonDelete_Click(object sender, EventArgs e) {
            if (dataGridView1.RowCount > 0) {
                var deleteResult = MessageCollections.ShowDeleteDialog();
                if (deleteResult) {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0) {
                        for (int i = 0; i < IdList.Count; i++) {
                            var result = await dataHelper.DeleteAsync(IdList[i]);
                            if (result == 1) {
                                // Save System Records
                                var systemReocrds = new SystemRecords {
                                    Title = "عملية حذف",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "تم حذف الصرف بالرقم التعريفي " + IdList[i].ToString(),
                                    AddedDate = DateTime.Now
                                };
                                await dataHelperSystemRecords.AddAsync(systemReocrds);
                                MessageCollections.ShowDeleteNotification();
                            } else {
                                MessageCollections.ShowErrorServer();
                            }
                        }
                        LoadData();
                    } else {
                        MessageCollections.ShowRequiredDeleteRow();
                    }
                    loadingForm.Hide();
                }
            } else {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            LoadData();
        }

        private async void buttonExport_Click(object sender, EventArgs e) {
            DataTable dataTable = new DataTable();
            // Convert List Od Data To DataTable
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            using (var reader = FastMember.ObjectReader.Create(data)) {
                dataTable.Load(reader);
            }
            loadingForm.Hide();
            // Re-Set Columns
            DataTable dataTableArranged = SetDatatableColumn(dataTable);
            // Export Data As Excel SpreadSheet
            ExportAsXLSXFile(dataTableArranged);
        }

        private void buttonSeach_Click(object sender, EventArgs e) {
            Search();
        }

        private void textBoxSeach_TextChanged(object sender, EventArgs e) {
            Search();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Edit();
        }

        private async void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e) {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            var dataId = data.Select(x => x.Id).ToArray();
            int index = comboBoxPage.SelectedIndex;
            int indexOfRow = Properties.Settings.Default.DataGridViewRowNumber * index;
            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[indexOfRow] && x.ProjectId == ProjectId).Take(Properties.Settings.Default.DataGridViewRowNumber).ToList();
            if (dataGridView1.DataSource == null) {
                MessageCollections.ShowErrorServer();
            } else {
                SetColumnTitles();
            }
            loadingForm.Hide();
            data.Clear();
        }

        #endregion

        #region Methods

        public async void LoadData() {
            loadingForm.Show(); 
            var data = await dataHelper.GetAllDataAsync();
            dataGridView1.DataSource = data.Where(x => x.ProjectId == ProjectId).Take(Properties.Settings.Default.DataGridViewRowNumber).ToList();
            // Add Number Of Page To ComboBox
            comboBoxPage.Items.Clear();
            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNumber));
            int pageNumber = (int) Math.Round(value, MidpointRounding.AwayFromZero);
            for (int i = 0; i < pageNumber; i++) {
                comboBoxPage.Items.Add(i);
            }
            if (dataGridView1.DataSource == null) {
                MessageCollections.ShowErrorServer();
            } else {
                SetColumnTitles();
            }
            loadingForm.Hide();
        }

        private void SetColumnTitles() {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "الصنف";
            dataGridView1.Columns[2].HeaderText = "المورد";
            dataGridView1.Columns[3].HeaderText = "تاريخ الصرف";
            dataGridView1.Columns[4].HeaderText = "رقم الوصل";
            dataGridView1.Columns[5].HeaderText = "المبلغ";
            dataGridView1.Columns[6].HeaderText = "التفاصيل";

            // Hide
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

        }

        private void Edit() {
            if (dataGridView1.RowCount > 0) {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddOutcomeForm addOutcomeForm = new AddOutcomeForm(RowId, ProjectId, this);
                addOutcomeForm.Show();
            } else {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private void SetIdRowForDelete() {
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Selected) {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }

        public async void Search() {
            loadingForm.Show();
            SearchItem = textBoxSeach.Text;
            var data = await dataHelper.SearchAsync(SearchItem);
            dataGridView1.DataSource = data.Where(x => x.ProjectId == ProjectId).ToList();   
            if (dataGridView1.DataSource == null) {
                MessageCollections.ShowErrorServer();
            } else {
                SetColumnTitles();
            }
            data.Clear();
            loadingForm.Hide();
        }

        private DataTable SetDatatableColumn(DataTable dataTable) {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";
            dataTable.Columns["CategoryName"].SetOrdinal(1);
            dataTable.Columns["CategoryName"].ColumnName = "الصنف";
            dataTable.Columns["SupplierName"].SetOrdinal(2);
            dataTable.Columns["SupplierName"].ColumnName = "المورد";
            dataTable.Columns["OutcomeDate"].SetOrdinal(3);
            dataTable.Columns["OutcomeDate"].ColumnName = "تاريخ الصرف";
            dataTable.Columns["ReceiveNumber"].SetOrdinal(4);
            dataTable.Columns["ReceiveNumber"].ColumnName = "رقم الوصل";
            dataTable.Columns["Amount"].SetOrdinal(5);
            dataTable.Columns["Amount"].ColumnName = "المبلغ";
            dataTable.Columns["Details"].SetOrdinal(6);
            dataTable.Columns["Details"].ColumnName = "التفاصيل";
            dataTable.Columns["CategoryId"].SetOrdinal(7);
            dataTable.Columns["CategoryId"].ColumnName = "CategoryId";
            dataTable.Columns["SupplierId"].SetOrdinal(8);
            dataTable.Columns["SupplierId"].ColumnName = "SupplierId";
            dataTable.Columns["ProjectId"].SetOrdinal(9);
            dataTable.Columns["ProjectId"].ColumnName = "ProjectId";

            // Hide 
            dataTable.Columns.Remove("CategoryId");
            dataTable.Columns.Remove("ProjectId");
            dataTable.Columns.Remove("SupplierId");
            dataTable.AcceptChanges();

            return dataTable;
        }

        private void ExportAsXLSXFile(DataTable dataTableArranged) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "xlsx تصدير الملف على شكل";
            saveFileDialog.DefaultExt = ".xslx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx) | *.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                try {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) { // Create Excel File
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); // Add Sheet
                        using (MemoryStream ma = new MemoryStream()) {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        #endregion
    
    }
}
