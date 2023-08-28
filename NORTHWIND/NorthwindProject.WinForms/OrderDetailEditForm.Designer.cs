namespace NorthwindProject.WinForms
{
    partial class OrderDetailEditForm
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
            cmbProduct = new ComboBox();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numQuantity = new NumericUpDown();
            numDiscount = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(99, 27);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(213, 23);
            cmbProduct.TabIndex = 0;
            cmbProduct.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün";
            label1.Click += label1_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(99, 70);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(213, 23);
            txtUnitPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 114);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 160);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "İndirim ";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(99, 114);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(213, 23);
            numQuantity.TabIndex = 8;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(99, 160);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(213, 23);
            numDiscount.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(237, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // OrderDetailEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(numDiscount);
            Controls.Add(numQuantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUnitPrice);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Name = "OrderDetailEditForm";
            Text = "OrderDetailEditForm";
            Load += OrderDetailEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private Label label1;
        private TextBox txtUnitPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numQuantity;
        private NumericUpDown numDiscount;
        private Button btnAdd;
    }
}