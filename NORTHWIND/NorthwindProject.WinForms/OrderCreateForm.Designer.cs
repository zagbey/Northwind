namespace NorthwindProject.WinForms
{
    partial class OrderCreateForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCustomerID = new ComboBox();
            cmbEmployeeID = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            dtpRequaredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            cmbShıpVia = new ComboBox();
            label7 = new Label();
            nmrFreight = new NumericUpDown();
            txtShipRegion = new TextBox();
            txtShipCity = new TextBox();
            txtShipAdress = new TextBox();
            txtShipName = new TextBox();
            txtShipPostalCode = new TextBox();
            txtShipCountry = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            gridOrderDetails = new DataGridView();
            label8 = new Label();
            btnAddProduct = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrFreight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "MüşteriID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "ÇalışanID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 103);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 9;
            label3.Text = "Sipariş Tarihi ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 10;
            label4.Text = "Termin Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 11;
            label5.Text = "Gönderme Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "ShıpVia";
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(111, 17);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(200, 23);
            cmbCustomerID.TabIndex = 13;
            // 
            // cmbEmployeeID
            // 
            cmbEmployeeID.FormattingEnabled = true;
            cmbEmployeeID.Location = new Point(111, 60);
            cmbEmployeeID.Name = "cmbEmployeeID";
            cmbEmployeeID.Size = new Size(200, 23);
            cmbEmployeeID.TabIndex = 14;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(111, 103);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 15;
            // 
            // dtpRequaredDate
            // 
            dtpRequaredDate.Location = new Point(111, 146);
            dtpRequaredDate.Name = "dtpRequaredDate";
            dtpRequaredDate.Size = new Size(200, 23);
            dtpRequaredDate.TabIndex = 16;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(111, 189);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(200, 23);
            dtpShippedDate.TabIndex = 17;
            // 
            // cmbShıpVia
            // 
            cmbShıpVia.FormattingEnabled = true;
            cmbShıpVia.Location = new Point(111, 232);
            cmbShıpVia.Name = "cmbShıpVia";
            cmbShıpVia.Size = new Size(200, 23);
            cmbShıpVia.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 274);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 19;
            label7.Text = "Freıght";
            // 
            // nmrFreight
            // 
            nmrFreight.Location = new Point(111, 274);
            nmrFreight.Name = "nmrFreight";
            nmrFreight.Size = new Size(200, 23);
            nmrFreight.TabIndex = 20;
            // 
            // txtShipRegion
            // 
            txtShipRegion.Location = new Point(512, 138);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(239, 23);
            txtShipRegion.TabIndex = 21;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(512, 100);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(239, 23);
            txtShipCity.TabIndex = 22;
            // 
            // txtShipAdress
            // 
            txtShipAdress.Location = new Point(512, 60);
            txtShipAdress.Name = "txtShipAdress";
            txtShipAdress.Size = new Size(239, 23);
            txtShipAdress.TabIndex = 23;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(512, 20);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(239, 23);
            txtShipName.TabIndex = 24;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Location = new Point(512, 181);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(239, 23);
            txtShipPostalCode.TabIndex = 27;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(512, 221);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(239, 23);
            txtShipCountry.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(441, 229);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 33;
            label9.Text = "Ülke";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(441, 189);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 32;
            label10.Text = "Post Kodu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(441, 146);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 31;
            label11.Text = "Bölge";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(441, 108);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 30;
            label12.Text = "Şehir";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(441, 63);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 29;
            label13.Text = "Açık Adres";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(441, 23);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 28;
            label14.Text = "Alıcı Adı";
            // 
            // gridOrderDetails
            // 
            gridOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrderDetails.Location = new Point(12, 356);
            gridOrderDetails.Name = "gridOrderDetails";
            gridOrderDetails.RowTemplate.Height = 25;
            gridOrderDetails.Size = new Size(739, 150);
            gridOrderDetails.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.AppWorkspace;
            label8.Location = new Point(12, 335);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 35;
            label8.Text = "Ürünler";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.Control;
            btnAddProduct.Location = new Point(675, 327);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(76, 23);
            btnAddProduct.TabIndex = 36;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(676, 512);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 37;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // OrderCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 673);
            Controls.Add(btnSave);
            Controls.Add(btnAddProduct);
            Controls.Add(label8);
            Controls.Add(gridOrderDetails);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(txtShipPostalCode);
            Controls.Add(txtShipCountry);
            Controls.Add(txtShipName);
            Controls.Add(txtShipAdress);
            Controls.Add(txtShipCity);
            Controls.Add(txtShipRegion);
            Controls.Add(nmrFreight);
            Controls.Add(label7);
            Controls.Add(cmbShıpVia);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequaredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(cmbEmployeeID);
            Controls.Add(cmbCustomerID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderCreateForm";
            Text = "Yeni Sipariş ";
            Load += OrderCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrFreight).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCustomerID;
        private ComboBox cmbEmployeeID;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequaredDate;
        private DateTimePicker dtpShippedDate;
        private ComboBox cmbShıpVia;
        private Label label7;
        private NumericUpDown nmrFreight;
        private TextBox txtShipRegion;
        private TextBox txtShipCity;
        private TextBox txtShipAdress;
        private TextBox txtShipName;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCountry;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView gridOrderDetails;
        private Label label8;
        private Button btnAddProduct;
        private Button btnSave;
    }
}