namespace NorthwindProject.WinForms
{
    partial class ProductUpdateForm
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
            btnSave = new Button();
            cmbSuplierID = new ComboBox();
            cmbCategoryID = new ComboBox();
            chkIsActive = new CheckBox();
            txtReorderLevel = new TextBox();
            txtUnistInOrder = new TextBox();
            txtUnitInStock = new TextBox();
            numUnitPrice = new NumericUpDown();
            txtQuantitiyPerUnit = new TextBox();
            txtProductName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(367, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 23);
            btnSave.TabIndex = 56;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbSuplierID
            // 
            cmbSuplierID.FormattingEnabled = true;
            cmbSuplierID.Location = new Point(198, 112);
            cmbSuplierID.Name = "cmbSuplierID";
            cmbSuplierID.Size = new Size(260, 23);
            cmbSuplierID.TabIndex = 55;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(198, 75);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(260, 23);
            cmbCategoryID.TabIndex = 54;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(198, 368);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(51, 19);
            chkIsActive.TabIndex = 53;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(198, 322);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(260, 23);
            txtReorderLevel.TabIndex = 52;
            // 
            // txtUnistInOrder
            // 
            txtUnistInOrder.Location = new Point(198, 280);
            txtUnistInOrder.Name = "txtUnistInOrder";
            txtUnistInOrder.Size = new Size(260, 23);
            txtUnistInOrder.TabIndex = 51;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(198, 238);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(260, 23);
            txtUnitInStock.TabIndex = 50;
            // 
            // numUnitPrice
            // 
            numUnitPrice.Location = new Point(198, 196);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(260, 23);
            numUnitPrice.TabIndex = 49;
            // 
            // txtQuantitiyPerUnit
            // 
            txtQuantitiyPerUnit.Location = new Point(198, 154);
            txtQuantitiyPerUnit.Name = "txtQuantitiyPerUnit";
            txtQuantitiyPerUnit.Size = new Size(260, 23);
            txtQuantitiyPerUnit.TabIndex = 48;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(198, 36);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(260, 23);
            txtProductName.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(99, 372);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 46;
            label9.Text = "Ürün Durumu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(99, 330);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 45;
            label8.Text = "Kritik Stok Eşiği";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 288);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 44;
            label7.Text = "Gelecek Stok";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 246);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 43;
            label6.Text = "Stok Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 204);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 42;
            label5.Text = "Birim Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 162);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 41;
            label4.Text = "Birim İçeriği";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 40;
            label3.Text = "Tedarikçi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 39;
            label2.Text = "Kategorisi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 38;
            label1.Text = "Ürün Adı";
            // 
            // ProductUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cmbSuplierID);
            Controls.Add(cmbCategoryID);
            Controls.Add(chkIsActive);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtUnistInOrder);
            Controls.Add(txtUnitInStock);
            Controls.Add(numUnitPrice);
            Controls.Add(txtQuantitiyPerUnit);
            Controls.Add(txtProductName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductUpdateForm";
            Text = "ProductUpdateForm";
            Load += ProductUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cmbSuplierID;
        private ComboBox cmbCategoryID;
        private CheckBox chkIsActive;
        private TextBox txtReorderLevel;
        private TextBox txtUnistInOrder;
        private TextBox txtUnitInStock;
        private NumericUpDown numUnitPrice;
        private TextBox txtQuantitiyPerUnit;
        private TextBox txtProductName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}