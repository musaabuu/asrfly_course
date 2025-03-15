﻿namespace Asrfly.Gui.GuiCategories
{
    partial class AddCustomersForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            richTextBoxDetails = new RichTextBox();
            comboBoxType = new ComboBox();
            textBoxBalance = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
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
            panel1.Location = new Point(0, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 88);
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
            buttonSaveAndClose.Location = new Point(402, 19);
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
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(6, 269);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(546, 120);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new Point(6, 181);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(546, 45);
            comboBoxType.TabIndex = 2;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new Point(6, 432);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(546, 45);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 392);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 229);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 141);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 0;
            label2.Text = "نوع الصنف";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 81);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(546, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(201, 141);
            label6.Name = "label6";
            label6.Size = new Size(25, 37);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(201, 41);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 41);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 658);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل صنف";
            TopMost = true;
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxBalance;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBoxDetails;
        private ComboBox comboBoxType;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label6;
        private Label label5;
    }
}