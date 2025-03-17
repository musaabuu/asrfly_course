namespace Asrfly.Gui.GuiSupliers {
    partial class AddSupliersForm {
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
            richTextBoxDetails = new RichTextBox();
            textBoxBalance = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label7 = new Label();
            label2 = new Label();
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
            panel1.Location = new Point(0, 593);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 88);
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
            buttonSaveAndClose.Location = new Point(625, 19);
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
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 570);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المورد";
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(6, 361);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(546, 120);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new Point(6, 506);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(546, 45);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(715, 514);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(693, 406);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(6, 291);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(546, 45);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(6, 221);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(546, 45);
            textBoxAddress.TabIndex = 1;
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(6, 151);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(546, 45);
            textBoxPhoneNumber.TabIndex = 1;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 81);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(546, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(643, 81);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 0;
            label5.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(643, 299);
            label9.Name = "label9";
            label9.Size = new Size(145, 37);
            label9.TabIndex = 0;
            label9.Text = "البريد الالكتروني";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(705, 229);
            label7.Name = "label7";
            label7.Size = new Size(77, 37);
            label7.TabIndex = 0;
            label7.Text = "العنوان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 159);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 0;
            label2.Text = "رقم الهاتف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 89);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم المورد";
            // 
            // AddSupliersForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 681);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSupliersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مورد";
            TopMost = true;
            Load += AddSupliersForm_Load;
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
        private RichTextBox richTextBoxDetails;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private Label label9;
        private Label label7;
        private Label label2;
    }
}