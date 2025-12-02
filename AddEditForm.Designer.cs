namespace TechGadgetCollection
{
    partial class frmAddEditForm
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
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            S = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            txtModelNumber = new TextBox();
            txtSerialNumber = new TextBox();
            txtPurchaseDate = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtWarantyUntil = new TextBox();
            txtFirmwareVersion = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            chkWorking = new CheckBox();
            rbUnderWarranty = new RadioButton();
            lblWarrantyStatus = new Label();
            rbOutOfWarranty = new RadioButton();
            btnExit = new Button();
            btnAddOrEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "&Title:";
            // 
            // txtTitle
            // 
            txtTitle.AcceptsTab = true;
            txtTitle.Location = new Point(135, 38);
            txtTitle.Margin = new Padding(2, 1, 2, 1);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "&Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Model &Number:";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Location = new Point(15, 144);
            S.Margin = new Padding(2, 0, 2, 0);
            S.Name = "S";
            S.Size = new Size(85, 15);
            S.TabIndex = 8;
            S.Text = "&Serial Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 180);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "&Purchase Date:";
            // 
            // txtDescription
            // 
            txtDescription.AcceptsTab = true;
            txtDescription.Location = new Point(444, 27);
            txtDescription.Margin = new Padding(2, 1, 2, 1);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(179, 67);
            txtDescription.TabIndex = 3;
            // 
            // txtModelNumber
            // 
            txtModelNumber.AcceptsTab = true;
            txtModelNumber.Location = new Point(135, 107);
            txtModelNumber.Margin = new Padding(2, 1, 2, 1);
            txtModelNumber.MaxLength = 20;
            txtModelNumber.Name = "txtModelNumber";
            txtModelNumber.Size = new Size(178, 23);
            txtModelNumber.TabIndex = 7;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.AcceptsTab = true;
            txtSerialNumber.Location = new Point(135, 142);
            txtSerialNumber.Margin = new Padding(2, 1, 2, 1);
            txtSerialNumber.MaxLength = 20;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(178, 23);
            txtSerialNumber.TabIndex = 9;
            // 
            // txtPurchaseDate
            // 
            txtPurchaseDate.AcceptsTab = true;
            txtPurchaseDate.Location = new Point(135, 179);
            txtPurchaseDate.Margin = new Padding(2, 1, 2, 1);
            txtPurchaseDate.Name = "txtPurchaseDate";
            txtPurchaseDate.Size = new Size(175, 23);
            txtPurchaseDate.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 220);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 19;
            label4.Text = "Warant&y Until:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 219);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "&Condition:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 110);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 14;
            label7.Text = "&Firmware Version:";
            // 
            // txtWarantyUntil
            // 
            txtWarantyUntil.Location = new Point(444, 218);
            txtWarantyUntil.Margin = new Padding(2, 1, 2, 1);
            txtWarantyUntil.Name = "txtWarantyUntil";
            txtWarantyUntil.Size = new Size(179, 23);
            txtWarantyUntil.TabIndex = 20;
            // 
            // txtFirmwareVersion
            // 
            txtFirmwareVersion.AcceptsTab = true;
            txtFirmwareVersion.Location = new Point(444, 107);
            txtFirmwareVersion.Margin = new Padding(2, 1, 2, 1);
            txtFirmwareVersion.MaxLength = 20;
            txtFirmwareVersion.Name = "txtFirmwareVersion";
            txtFirmwareVersion.Size = new Size(179, 23);
            txtFirmwareVersion.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 77);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 4;
            label8.Text = "&Manufacturer:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 131);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.AcceptsTab = true;
            textBox4.Location = new Point(135, 76);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 23);
            textBox4.TabIndex = 5;
            // 
            // chkWorking
            // 
            chkWorking.AutoSize = true;
            chkWorking.Checked = true;
            chkWorking.CheckState = CheckState.Checked;
            chkWorking.Location = new Point(146, 219);
            chkWorking.Margin = new Padding(2, 1, 2, 1);
            chkWorking.Name = "chkWorking";
            chkWorking.Size = new Size(127, 19);
            chkWorking.TabIndex = 13;
            chkWorking.Text = "Working Condition";
            chkWorking.UseVisualStyleBackColor = true;
            // 
            // rbUnderWarranty
            // 
            rbUnderWarranty.AutoSize = true;
            rbUnderWarranty.Checked = true;
            rbUnderWarranty.ForeColor = SystemColors.ControlText;
            rbUnderWarranty.Location = new Point(454, 152);
            rbUnderWarranty.Margin = new Padding(2, 1, 2, 1);
            rbUnderWarranty.Name = "rbUnderWarranty";
            rbUnderWarranty.Size = new Size(108, 19);
            rbUnderWarranty.TabIndex = 17;
            rbUnderWarranty.TabStop = true;
            rbUnderWarranty.Text = "&Under Warranty";
            rbUnderWarranty.UseVisualStyleBackColor = true;
            // 
            // lblWarrantyStatus
            // 
            lblWarrantyStatus.AutoSize = true;
            lblWarrantyStatus.Location = new Point(328, 162);
            lblWarrantyStatus.Margin = new Padding(2, 0, 2, 0);
            lblWarrantyStatus.Name = "lblWarrantyStatus";
            lblWarrantyStatus.Size = new Size(93, 15);
            lblWarrantyStatus.TabIndex = 16;
            lblWarrantyStatus.Text = "&Warranty Status:";
            // 
            // rbOutOfWarranty
            // 
            rbOutOfWarranty.AutoSize = true;
            rbOutOfWarranty.BackColor = Color.IndianRed;
            rbOutOfWarranty.Location = new Point(454, 179);
            rbOutOfWarranty.Margin = new Padding(2, 1, 2, 1);
            rbOutOfWarranty.Name = "rbOutOfWarranty";
            rbOutOfWarranty.Size = new Size(110, 19);
            rbOutOfWarranty.TabIndex = 18;
            rbOutOfWarranty.TabStop = true;
            rbOutOfWarranty.Text = "&Out of Warranty";
            rbOutOfWarranty.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(523, 268);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 22);
            btnExit.TabIndex = 23;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(411, 268);
            btnAddOrEdit.Margin = new Padding(2, 1, 2, 1);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(81, 22);
            btnAddOrEdit.TabIndex = 24;
            btnAddOrEdit.Text = "A&dd/Edit";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            // 
            // frmAddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 298);
            Controls.Add(btnAddOrEdit);
            Controls.Add(btnExit);
            Controls.Add(rbOutOfWarranty);
            Controls.Add(lblWarrantyStatus);
            Controls.Add(rbUnderWarranty);
            Controls.Add(chkWorking);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtFirmwareVersion);
            Controls.Add(txtWarantyUntil);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtPurchaseDate);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtModelNumber);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(S);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Tech Gadget";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private Label label3;
        private Label S;
        private Label label5;
        private TextBox txtDescription;
        private TextBox txtModelNumber;
        private TextBox txtSerialNumber;
        private TextBox txtPurchaseDate;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtWarantyUntil;
        private TextBox txtFirmwareVersion;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private CheckBox chkWorking;
        private RadioButton rbUnderWarranty;
        private Label lblWarrantyStatus;
        private RadioButton rbOutOfWarranty;
        private Button btnExit;
        private Button btnAddOrEdit;
    }
}