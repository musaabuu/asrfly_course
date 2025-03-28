using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiProjects {
    public partial class ProjectsManagementForm : Form {
        private readonly int projectId;

        public ProjectsManagementForm(int ProjectId) {
            InitializeComponent();
            projectId = ProjectId;
            LoadOutcomeUI();
        }

        private void LoadOutcomeUI() {
            GuiOutcome.OutcomeUserControl outcomeUserControl = new GuiOutcome.OutcomeUserControl(projectId);
            outcomeUserControl.Dock = DockStyle.Fill;
            panelOutcome.Controls.Add(outcomeUserControl);
        }
    }
}
