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

            pageManager.LoadPage(Gui.GuiCategories.CustomersUserControl.Instance());

        }
    }
}
