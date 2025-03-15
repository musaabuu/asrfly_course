namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutput = new Button();
            buttonAddUser = new Button();
            buttonAddProject = new Button();
            buttonAddSuppleir = new Button();
            buttonAddCustomer = new Button();
            button2 = new Button();
            buttonAddCategory = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 295);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.Smart;
            pictureBox1.Location = new Point(445, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(578, 44);
            label1.Name = "label1";
            label1.Size = new Size(205, 56);
            label1.TabIndex = 2;
            label1.Text = "الوصول السريع";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSuppleir);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new Point(28, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1196, 141);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddInput.Image = Properties.Resources.Receipt;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(21, 46);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(142, 68);
            buttonAddInput.TabIndex = 1;
            buttonAddInput.Text = "قبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddOutput.Image = Properties.Resources.Exchange_1;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(189, 46);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(142, 68);
            buttonAddOutput.TabIndex = 1;
            buttonAddOutput.Text = "صرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddUser.Image = Properties.Resources.User;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(357, 46);
            buttonAddUser.Margin = new Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(142, 68);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "مستخدم";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddProject.Image = Properties.Resources.Microsoft_Project;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(525, 46);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(142, 68);
            buttonAddProject.TabIndex = 1;
            buttonAddProject.Text = "مشروع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSuppleir
            // 
            buttonAddSuppleir.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddSuppleir.Image = Properties.Resources.Supplier;
            buttonAddSuppleir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSuppleir.Location = new Point(693, 46);
            buttonAddSuppleir.Margin = new Padding(5);
            buttonAddSuppleir.Name = "buttonAddSuppleir";
            buttonAddSuppleir.Size = new Size(142, 68);
            buttonAddSuppleir.TabIndex = 1;
            buttonAddSuppleir.Text = "مورد";
            buttonAddSuppleir.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddCustomer.Image = Properties.Resources.Customer;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(861, 46);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(142, 68);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.Home;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(496, 46);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 1;
            button2.Text = "صنف";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddCategory.Image = Properties.Resources.Categorize;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(1029, 46);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(142, 68);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 599);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddInput;
        private Button buttonAddUser;
        private Button buttonAddProject;
        private Button buttonAddSuppleir;
        private Button buttonAddCustomer;
        private Button button2;
        private Button buttonAddCategory;
        private PictureBox pictureBox1;
        private Button buttonAddOutput;
    }
}
