using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiHome {
    public partial class HomeUserControl : UserControl {
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl() {
            InitializeComponent();
        }

        //public static HomeUserControl Instance() {
        //    return _HomeUserControl ?? (new HomeUserControl());
        //}

        public static HomeUserControl Instance() {
            if (_HomeUserControl == null) {
                _HomeUserControl = new HomeUserControl();
            }
            return _HomeUserControl;
        }
    }
}
