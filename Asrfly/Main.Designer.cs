namespace Asrfly
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonCategories = new Button();
            buttonCustomers = new Button();
            buttonSuppliers = new Button();
            buttonProjects = new Button();
            buttonUsers = new Button();
            buttonSettings = new Button();
            buttonLogout = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(buttonHome);
            flowLayoutPanel2.Controls.Add(buttonCategories);
            flowLayoutPanel2.Controls.Add(buttonCustomers);
            flowLayoutPanel2.Controls.Add(buttonSuppliers);
            flowLayoutPanel2.Controls.Add(buttonProjects);
            flowLayoutPanel2.Controls.Add(buttonUsers);
            flowLayoutPanel2.Controls.Add(buttonSettings);
            flowLayoutPanel2.Controls.Add(buttonLogout);
            flowLayoutPanel2.Controls.Add(buttonHelp);
            flowLayoutPanel2.Controls.Add(buttonAbout);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 599);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(1262, 74);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.Home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(1061, 10);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(165, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسة";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategories
            // 
            buttonCategories.Image = Properties.Resources.Categorize;
            buttonCategories.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategories.Location = new Point(886, 10);
            buttonCategories.Margin = new Padding(5);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(165, 55);
            buttonCategories.TabIndex = 0;
            buttonCategories.Text = "الاصناف";
            buttonCategories.UseVisualStyleBackColor = true;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.User_Group_Skin_Type_7;
            buttonCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new Point(711, 10);
            buttonCustomers.Margin = new Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(165, 55);
            buttonCustomers.TabIndex = 0;
            buttonCustomers.Text = "العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.Supplier;
            buttonSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new Point(536, 10);
            buttonSuppliers.Margin = new Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new Size(165, 55);
            buttonSuppliers.TabIndex = 0;
            buttonSuppliers.Text = "الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            buttonProjects.Image = Properties.Resources.Microsoft_Project;
            buttonProjects.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Location = new Point(361, 10);
            buttonProjects.Margin = new Padding(5);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(165, 55);
            buttonProjects.TabIndex = 0;
            buttonProjects.Text = "المشاريع";
            buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.User;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(186, 10);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(165, 55);
            buttonUsers.TabIndex = 0;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.Settings;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(11, 10);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(165, 55);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "الاعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Image = Properties.Resources.Logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(1061, 75);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(165, 55);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "خروج";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(886, 75);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(165, 55);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "المساعدة";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.About;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(711, 75);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(165, 55);
            buttonAbout.TabIndex = 4;
            buttonAbout.Text = "حول";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 599);
            panelContainer.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asrfly";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonHome;
        private Button buttonCategories;
        private Button buttonCustomers;
        private Button buttonSuppliers;
        private Button buttonProjects;
        private Button buttonUsers;
        private Button buttonSettings;
        private Button buttonLogout;
        private Button buttonHelp;
        private Button buttonAbout;
        public Panel panelContainer;
    }
}
