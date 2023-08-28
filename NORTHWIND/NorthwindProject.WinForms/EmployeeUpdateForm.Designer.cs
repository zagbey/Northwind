namespace NorthwindProject.WinForms
{
    partial class EmployeeUpdateForm
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
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtExtension = new TextBox();
            txtNote = new TextBox();
            btnAdd = new Button();
            label12 = new Label();
            label11 = new Label();
            txtHomePhone = new TextBox();
            txtCountry = new TextBox();
            txtPostalCode = new TextBox();
            label10 = new Label();
            txtRegion = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtAdress = new TextBox();
            label6 = new Label();
            dtpHireDate = new DateTimePicker();
            label5 = new Label();
            dtpBirtDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitleOfCourtesy = new TextBox();
            txtTitle = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            cmbManager = new ComboBox();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 480);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 60;
            label13.Text = "Rapor Verdiği Id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(36, 451);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 59;
            label14.Text = "Not";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(36, 425);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 58;
            label15.Text = "Alan Kodu";
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(144, 425);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(202, 23);
            txtExtension.TabIndex = 12;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(144, 454);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(202, 23);
            txtNote.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(271, 554);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 396);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 54;
            label12.Text = "Ev Telefonu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 367);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 53;
            label11.Text = "Ülke";
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(144, 396);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(202, 23);
            txtHomePhone.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(144, 367);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(202, 23);
            txtCountry.TabIndex = 10;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(144, 338);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(202, 23);
            txtPostalCode.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 341);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 49;
            label10.Text = "Posta Kodu";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(144, 309);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(202, 23);
            txtRegion.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 309);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 47;
            label9.Text = "Bölge";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 280);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 46;
            label8.Text = "Şehir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 203);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 44;
            label7.Text = "Adres";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(144, 200);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(202, 74);
            txtAdress.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 171);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 42;
            label6.Text = "İşe Giriş Tarihi";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(144, 171);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(202, 23);
            dtpHireDate.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 142);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 40;
            label5.Text = "Doğum Tarihi";
            // 
            // dtpBirtDate
            // 
            dtpBirtDate.Location = new Point(144, 142);
            dtpBirtDate.Name = "dtpBirtDate";
            dtpBirtDate.Size = new Size(202, 23);
            dtpBirtDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 110);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 38;
            label4.Text = "Kısa Ünv.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 82);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 37;
            label3.Text = "Ünvan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 54);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 36;
            label2.Text = "Soyadı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 35;
            label1.Text = "Adı";
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(144, 113);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(202, 23);
            txtTitleOfCourtesy.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(144, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(202, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(144, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(202, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(144, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(202, 23);
            txtFirstName.TabIndex = 0;
            // 
            // cmbManager
            // 
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(144, 483);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(203, 23);
            cmbManager.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(144, 280);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(202, 23);
            txtCity.TabIndex = 7;
            // 
            // EmployeeUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(txtCity);
            Controls.Add(cmbManager);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtExtension);
            Controls.Add(txtNote);
            Controls.Add(btnAdd);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtHomePhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(label10);
            Controls.Add(txtRegion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtAdress);
            Controls.Add(label6);
            Controls.Add(dtpHireDate);
            Controls.Add(label5);
            Controls.Add(dtpBirtDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitleOfCourtesy);
            Controls.Add(txtTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "EmployeeUpdateForm";
            Text = "EmployeeUpdateForm";
            Load += EmployeeUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtExtension;
        private TextBox txtNote;
        private Button btnAdd;
        private Label label12;
        private Label label11;
        private TextBox txtHomePhone;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private Label label10;
        private TextBox txtRegion;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtAdress;
        private Label label6;
        private DateTimePicker dtpHireDate;
        private Label label5;
        private DateTimePicker dtpBirtDate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTitleOfCourtesy;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ComboBox cmbManager;
        private TextBox txtCity;
    }
}