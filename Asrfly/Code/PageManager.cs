using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Asrfly.Code {
    public class PageManager {
        private readonly Main main;
        public PageManager(Main main) {
            this.main = main;
        }

        public void LoadPage(UserControl PageUserControl) {
            // Load Current Page

            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null) {
                // Remove Current 

                main.panelContainer.Controls.Remove(oldPage);
                oldPage.Dispose();
            }

            // Load New Page

            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
