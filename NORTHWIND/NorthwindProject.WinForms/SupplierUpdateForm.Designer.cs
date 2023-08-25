namespace NorthwindProject.WinForms
{
    partial class SupplierUpdateForm
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
            label8 = new Label();
            btnSave = new Button();
            label1 = new Label();
            txtHomePage = new TextBox();
            txtFax = new TextBox();
            txtPhone = new TextBox();
            txtCountry = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtAdress = new TextBox();
            txtContactTitle = new TextBox();
            txtContactName = new TextBox();
            txtCompanyName = new TextBox();
            label9 = new Label();
            label55 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label122 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 395);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 47;
            label8.Text = "Fax";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(328, 491);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 46;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 438);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 45;
            label1.Text = "İnternet Adresi";
            // 
            // txtHomePage
            // 
            txtHomePage.Location = new Point(167, 438);
            txtHomePage.Name = "txtHomePage";
            txtHomePage.Size = new Size(236, 23);
            txtHomePage.TabIndex = 44;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(167, 395);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(236, 23);
            txtFax.TabIndex = 43;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(167, 351);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 23);
            txtPhone.TabIndex = 42;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(167, 308);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(236, 23);
            txtCountry.TabIndex = 41;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(167, 271);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(236, 23);
            txtPostalCode.TabIndex = 40;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(167, 221);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(236, 23);
            txtRegion.TabIndex = 39;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(167, 184);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(236, 23);
            txtCity.TabIndex = 38;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(167, 102);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(236, 73);
            txtAdress.TabIndex = 37;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(167, 65);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(236, 23);
            txtContactTitle.TabIndex = 36;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(167, 28);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(236, 23);
            txtContactName.TabIndex = 35;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(337, -36);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(236, 23);
            txtCompanyName.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 351);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 33;
            label9.Text = "Telefon";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(61, 308);
            label55.Name = "label55";
            label55.Size = new Size(30, 15);
            label55.TabIndex = 32;
            label55.Text = "Ülke";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 271);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 31;
            label7.Text = "PostKodu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 221);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 30;
            label6.Text = "Bölge";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 184);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 29;
            label5.Text = "Şehir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 102);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 28;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 65);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 27;
            label3.Text = "Ünvan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 38);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 26;
            label2.Text = "İleşitime Adı";
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.Location = new Point(227, -36);
            label122.Name = "label122";
            label122.Size = new Size(57, 15);
            label122.TabIndex = 25;
            label122.Text = "Şirket Adı";
            // 
            // SupplierUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 649);
            Controls.Add(label8);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtHomePage);
            Controls.Add(txtFax);
            Controls.Add(txtPhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAdress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(label9);
            Controls.Add(label55);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label122);
            Name = "SupplierUpdateForm";
            Text = "SupplierUpdateForm";
            Load += SupplierUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btnSave;
        private Label label1;
        private TextBox txtHomePage;
        private TextBox txtFax;
        private TextBox txtPhone;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtAdress;
        private TextBox txtContactTitle;
        private TextBox txtContactName;
        private TextBox txtCompanyName;
        private Label label9;
        private Label label55;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label122;
    }
}