using Asrfly.Code;

namespace Asrfly {
    public partial class Main : Form {
        private readonly PageManager pageManager;
        public Main() {
            InitializeComponent();
            pageManager = new PageManager(this);

            // Load Home Page

            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        #region Events

        private void buttonHome_Click(object sender, EventArgs e) {
            // Load Home Page 

            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        #endregion

        private void buttonCategories_Click(object sender, EventArgs e) {
            // Load Category Page

            pageManager.LoadPage(Gui.GuiCategories.CategoryUserControl.Instance());

        }

        private void buttonCustomers_Click(object sender, EventArgs e) {
            // Load Customers Page

            pageManager.LoadPage(Gui.GuiCustomers.CustomersUserControl.Instance());
        }

        private void buttonSuppliers_Click(object sender, EventArgs e) {
            // Load Suppliers Page 

            pageManager.LoadPage(Gui.GuiSuppliers.SuppliersUserControl.Instance());
        }

        private void buttonProjects_Click(object sender, EventArgs e) {
            // Load Projects Page 

            pageManager.LoadPage(Gui.GuiProjects.ProjectsUserControl.Instance());
        }
    }
}
