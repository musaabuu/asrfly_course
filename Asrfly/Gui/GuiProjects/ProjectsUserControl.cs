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

namespace Asrfly.Gui.GuiProjects {
    public partial class ProjectsUserControl : UserControl {
        private readonly IDataHelper<Projects> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private static ProjectsUserControl _ProjectsUserControl;
        private int RowId;
        private readonly Gui.GuiLoading.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();
        private string SearchItem;

        public ProjectsUserControl() {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigurationObjectManager.GetObject("Projects");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            LoadData();
        }

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e) {
            AddProjectsForm addProjectsForm = new AddProjectsForm(0, this);
            addProjectsForm.Show();
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
                                    Details = "تم حذف المشروع بالرقم التعريفي " + IdList[i].ToString(),
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
            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[indexOfRow]).Take(Properties.Settings.Default.DataGridViewRowNumber).ToList();
            if (dataGridView1.DataSource == null) {
                MessageCollections.ShowErrorServer();
            } else {
                SetColumnTitles();
            }
            loadingForm.Hide();
            data.Clear();
        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            if (dataGridView1.RowCount > 0) {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ProjectsManagementForm addProjectForm = new ProjectsManagementForm(RowId);
                addProjectForm.Show();
            }
        }

        #endregion

        #region Methods

        public static ProjectsUserControl Instance() {
            return _ProjectsUserControl ?? (new ProjectsUserControl());
        }

        public async void LoadData() {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNumber).ToList();
            // Add Number Of Page To ComboBox
            comboBoxPage.Items.Clear();
            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNumber));
            int pageNumber = (int)Math.Round(value, MidpointRounding.AwayFromZero);
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
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "العميل";
            dataGridView1.Columns[3].HeaderText = "العنوان";
            dataGridView1.Columns[4].HeaderText = "الشركة المنفذة";
            dataGridView1.Columns[5].HeaderText = "بداية المشروع";
            dataGridView1.Columns[6].HeaderText = "نهاية المشروع";
            dataGridView1.Columns[7].HeaderText = "التفاصيل";
            dataGridView1.Columns[8].HeaderText = "المفبوضات";
            dataGridView1.Columns[9].HeaderText = "المصروفات";
            dataGridView1.Columns[10].HeaderText = "الارباح";
            dataGridView1.Columns[11].HeaderText = "تاريخ الاضافة";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void Edit() {
            if (dataGridView1.RowCount > 0) {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddProjectsForm addProjectsForm = new AddProjectsForm(RowId, this);
                addProjectsForm.Show();
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
            dataGridView1.DataSource = await dataHelper.SearchAsync(SearchItem);
            if (dataGridView1.DataSource == null) {
                MessageCollections.ShowErrorServer();
            } else {
                SetColumnTitles();
            }
            loadingForm.Hide();
        }

        private DataTable SetDatatableColumn(DataTable dataTable) {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";
            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "الاسم";
            dataTable.Columns["Customer"].SetOrdinal(2);
            dataTable.Columns["Customer"].ColumnName = "العميل";
            dataTable.Columns["Address"].SetOrdinal(3);
            dataTable.Columns["Address"].ColumnName = "العنوان";
            dataTable.Columns["Company"].SetOrdinal(4);
            dataTable.Columns["Company"].ColumnName = "الشركة المنفذة";
            dataTable.Columns["StartDate"].SetOrdinal(5);
            dataTable.Columns["StartDate"].ColumnName = "بداية المشروع";
            dataTable.Columns["FinishDate"].SetOrdinal(6);
            dataTable.Columns["FinishDate"].ColumnName = "نهاية المشروع";
            dataTable.Columns["Details"].SetOrdinal(7);
            dataTable.Columns["Details"].ColumnName = "التفاصيل";
            dataTable.Columns["Income"].SetOrdinal(8);
            dataTable.Columns["Income"].ColumnName = "المقبوضات";
            dataTable.Columns["Outcome"].SetOrdinal(9);
            dataTable.Columns["Outcome"].ColumnName = "المصروفات";
            dataTable.Columns["Revenue"].SetOrdinal(10);
            dataTable.Columns["Revenue"].ColumnName = "الارباح";
            dataTable.Columns["AddedDate"].SetOrdinal(10);
            dataTable.Columns["AddedDate"].ColumnName = "تاريخ الاضافة";
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
