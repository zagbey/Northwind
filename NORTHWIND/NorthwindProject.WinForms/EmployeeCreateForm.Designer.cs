namespace NorthwindProject.WinForms
{
    partial class EmployeeCreateForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTitle = new TextBox();
            txtTitleOfCourtesy = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpBirtDate = new DateTimePicker();
            label5 = new Label();
            dtpHireDate = new DateTimePicker();
            label6 = new Label();
            txtAdress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRegion = new TextBox();
            label10 = new Label();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            txtHomePhone = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnAdd = new Button();
            txtNote = new TextBox();
            txtExtension = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cmbManager = new ComboBox();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(141, 14);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(202, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(141, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(202, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(141, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(202, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(141, 101);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(202, 23);
            txtTitleOfCourtesy.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 14);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 42);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 70);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Ünvan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 98);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Kısa Ünv.";
            // 
            // dtpBirtDate
            // 
            dtpBirtDate.Location = new Point(141, 130);
            dtpBirtDate.Name = "dtpBirtDate";
            dtpBirtDate.Size = new Size(202, 23);
            dtpBirtDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 130);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Doğum Tarihi";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(141, 159);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(202, 23);
            dtpHireDate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 159);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 11;
            label6.Text = "İşe Giriş Tarihi";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(141, 188);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(202, 74);
            txtAdress.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 191);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 13;
            label7.Text = "Adres";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 268);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 15;
            label8.Text = "Şehir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 297);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 16;
            label9.Text = "Bölge";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(141, 297);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(202, 23);
            txtRegion.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 329);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 18;
            label10.Text = "Posta Kodu";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(141, 326);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(202, 23);
            txtPostalCode.TabIndex = 19;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(141, 355);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(202, 23);
            txtCountry.TabIndex = 20;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(141, 384);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(202, 23);
            txtHomePhone.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 355);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 22;
            label11.Text = "Ülke";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 384);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 23;
            label12.Text = "Ev Telefonu";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(268, 542);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(141, 442);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(202, 23);
            txtNote.TabIndex = 25;
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(141, 413);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(202, 23);
            txtExtension.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 468);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 29;
            label13.Text = "Rapor Verdiği Id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 439);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 28;
            label14.Text = "Not";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 413);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 27;
            label15.Text = "Alan Kodu";
            // 
            // cmbManager
            // 
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(141, 471);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(202, 23);
            cmbManager.TabIndex = 30;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(141, 268);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(202, 23);
            txtCity.TabIndex = 31;
            // 
            // EmployeeCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
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
            Name = "EmployeeCreateForm";
            Text = "EmployeeCreateForm";
            Load += EmployeeCreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTitle;
        private TextBox txtTitleOfCourtesy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpBirtDate;
        private Label label5;
        private DateTimePicker dtpHireDate;
        private Label label6;
        private TextBox txtAdress;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtRegion;
        private Label label10;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtHomePhone;
        private Label label11;
        private Label label12;
        private Button btnAdd;
        private TextBox txtNote;
        private TextBox txtExtension;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cmbManager;
        private TextBox txtCity;
    }
}