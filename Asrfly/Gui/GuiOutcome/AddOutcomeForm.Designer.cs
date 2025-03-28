namespace Asrfly.Gui.GuiOutcome {
    partial class AddOutcomeForm {
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
            textBoxAmount = new TextBox();
            textBoxReceiveNumber = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            comboBoxSupplier = new ComboBox();
            richTextBoxDetails = new RichTextBox();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            labelSupplier = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 88);
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
            buttonSave.TabIndex = 7;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.Save;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(369, 19);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(175, 55);
            buttonSaveAndClose.TabIndex = 6;
            buttonSaveAndClose.Text = "حفظ و غلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(textBoxReceiveNumber);
            groupBox1.Controls.Add(dateTimePickerDate);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(comboBoxSupplier);
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelSupplier);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 570);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المشروع";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(15, 381);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(321, 45);
            textBoxAmount.TabIndex = 4;
            textBoxAmount.Text = "0";
            textBoxAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxReceiveNumber
            // 
            textBoxReceiveNumber.Location = new Point(15, 303);
            textBoxReceiveNumber.Name = "textBoxReceiveNumber";
            textBoxReceiveNumber.Size = new Size(321, 45);
            textBoxReceiveNumber.TabIndex = 3;
            textBoxReceiveNumber.Text = "0";
            textBoxReceiveNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(15, 225);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(321, 45);
            dateTimePickerDate.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(15, 69);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(321, 45);
            comboBoxCategory.TabIndex = 0;
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSupplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(15, 147);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(321, 45);
            comboBoxSupplier.TabIndex = 1;
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(15, 459);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(321, 93);
            richTextBoxDetails.TabIndex = 5;
            richTextBoxDetails.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 485);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 233);
            label6.Name = "label6";
            label6.Size = new Size(111, 37);
            label6.TabIndex = 0;
            label6.Text = "تاريخ الصرف";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 389);
            label8.Name = "label8";
            label8.Size = new Size(67, 37);
            label8.TabIndex = 0;
            label8.Text = "المبلغ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(389, 233);
            label11.Name = "label11";
            label11.Size = new Size(25, 37);
            label11.TabIndex = 0;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(429, 389);
            label10.Name = "label10";
            label10.Size = new Size(25, 37);
            label10.TabIndex = 0;
            label10.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(348, 155);
            label4.Name = "label4";
            label4.Size = new Size(25, 37);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(429, 72);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 311);
            label7.Name = "label7";
            label7.Size = new Size(104, 37);
            label7.TabIndex = 0;
            label7.Text = "رقم الوصل";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(379, 155);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(150, 37);
            labelSupplier.TabIndex = 0;
            labelSupplier.Text = "المورد (المستلم)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 77);
            label1.Name = "label1";
            label1.Size = new Size(72, 37);
            label1.TabIndex = 0;
            label1.Text = "الصنف";
            // 
            // AddOutcomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 678);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOutcomeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مشروع";
            TopMost = true;
            Load += AddOutcomeForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBoxDetails;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private Label labelSupplier;
        private Label label6;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxSupplier;
        private ComboBox comboBoxCategory;
        private TextBox textBoxAmount;
        private TextBox textBoxReceiveNumber;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label4;
    }
}