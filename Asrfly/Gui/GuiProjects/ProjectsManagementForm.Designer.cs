namespace Asrfly.Gui.GuiProjects {
    partial class ProjectsManagementForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelIncome = new Panel();
            panelOutcome = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 116);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(2, 0);
            label4.Name = "label4";
            label4.Size = new Size(265, 116);
            label4.TabIndex = 3;
            label4.Text = "الارباح";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(267, 0);
            label3.Name = "label3";
            label3.Size = new Size(265, 116);
            label3.TabIndex = 2;
            label3.Text = "المقبوضات ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(532, 0);
            label2.Name = "label2";
            label2.Size = new Size(265, 116);
            label2.TabIndex = 1;
            label2.Text = "المصروفات";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(797, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 116);
            label1.TabIndex = 0;
            label1.Text = "اسم المشروع";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelIncome, 1, 0);
            tableLayoutPanel1.Controls.Add(panelOutcome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1062, 557);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelIncome
            // 
            panelIncome.Dock = DockStyle.Fill;
            panelIncome.Location = new Point(3, 3);
            panelIncome.Name = "panelIncome";
            panelIncome.Size = new Size(525, 551);
            panelIncome.TabIndex = 0;
            // 
            // panelOutcome
            // 
            panelOutcome.Dock = DockStyle.Fill;
            panelOutcome.Location = new Point(534, 3);
            panelOutcome.Name = "panelOutcome";
            panelOutcome.Size = new Size(525, 551);
            panelOutcome.TabIndex = 1;
            // 
            // ProjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "ProjectsManagementForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المشروع";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelIncome;
        private Panel panelOutcome;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}