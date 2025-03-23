namespace Asrfly.Gui.GuiProjects {
    partial class AddProjectsForm {
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
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerFinishDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            comboBoxCustomer = new ComboBox();
            richTextBoxDetails = new RichTextBox();
            label3 = new Label();
            textBoxCompany = new TextBox();
            textBoxAddress = new TextBox();
            label8 = new Label();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxRevenue = new TextBox();
            label11 = new Label();
            textBoxOutcome = new TextBox();
            label10 = new Label();
            textBoxIncome = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 88);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.Save_1;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(18, 19);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 55);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.Save;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(915, 19);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(175, 55);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "حفظ و غلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerFinishDate);
            groupBox1.Controls.Add(dateTimePickerStartDate);
            groupBox1.Controls.Add(comboBoxCustomer);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 570);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المشروع";
            // 
            // dateTimePickerFinishDate
            // 
            dateTimePickerFinishDate.Location = new Point(15, 393);
            dateTimePickerFinishDate.Name = "dateTimePickerFinishDate";
            dateTimePickerFinishDate.Size = new Size(321, 45);
            dateTimePickerFinishDate.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(15, 329);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(321, 45);
            dateTimePickerStartDate.TabIndex = 5;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(15, 134);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(321, 45);
            comboBoxCustomer.TabIndex = 4;
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(15, 459);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(321, 93);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 486);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(15, 264);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(321, 45);
            textBoxCompany.TabIndex = 1;
            textBoxCompany.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(15, 199);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(321, 45);
            textBoxAddress.TabIndex = 1;
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 402);
            label8.Name = "label8";
            label8.Size = new Size(132, 37);
            label8.TabIndex = 0;
            label8.Text = "نهاية المشروع";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 69);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(321, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 337);
            label6.Name = "label6";
            label6.Size = new Size(129, 37);
            label6.TabIndex = 0;
            label6.Text = "بداية المشروع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(371, 77);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(371, 272);
            label9.Name = "label9";
            label9.Size = new Size(147, 37);
            label9.TabIndex = 0;
            label9.Text = "الشركة المنفدة";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 207);
            label7.Name = "label7";
            label7.Size = new Size(77, 37);
            label7.TabIndex = 0;
            label7.Text = "العنوان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 142);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 0;
            label2.Text = "العميل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 77);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم المشروع";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxRevenue);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxOutcome);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxIncome);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(548, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 570);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ملخص الاموال";
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Enabled = false;
            textBoxRevenue.Location = new Point(50, 387);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new Size(399, 45);
            textBoxRevenue.TabIndex = 1;
            textBoxRevenue.Text = "0";
            textBoxRevenue.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(218, 329);
            label11.Name = "label11";
            label11.Size = new Size(63, 37);
            label11.TabIndex = 0;
            label11.Text = "الارباح";
            // 
            // textBoxOutcome
            // 
            textBoxOutcome.Enabled = false;
            textBoxOutcome.Location = new Point(50, 263);
            textBoxOutcome.Name = "textBoxOutcome";
            textBoxOutcome.Size = new Size(399, 45);
            textBoxOutcome.TabIndex = 1;
            textBoxOutcome.Text = "0";
            textBoxOutcome.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(195, 205);
            label10.Name = "label10";
            label10.Size = new Size(109, 37);
            label10.TabIndex = 0;
            label10.Text = "المصروفات";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Enabled = false;
            textBoxIncome.Location = new Point(50, 139);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(399, 45);
            textBoxIncome.TabIndex = 1;
            textBoxIncome.Text = "0";
            textBoxIncome.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 81);
            label4.Name = "label4";
            label4.Size = new Size(111, 37);
            label4.TabIndex = 0;
            label4.Text = "المقبوضات";
            // 
            // AddProjectsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 678);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProjectsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مشروع";
            TopMost = true;
            Load += AddProjectsForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxName;
        private Label label3;
        private RichTextBox richTextBoxDetails;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private TextBox textBoxCompany;
        private TextBox textBoxAddress;
        private Label label9;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox textBoxIncome;
        private Label label4;
        private DateTimePicker dateTimePickerFinishDate;
        private DateTimePicker dateTimePickerStartDate;
        private ComboBox comboBoxCustomer;
        private TextBox textBoxRevenue;
        private Label label11;
        private TextBox textBoxOutcome;
        private Label label10;
    }
}