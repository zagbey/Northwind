namespace NorthwindProject.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            yeniSiparişToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuNewProduct = new ToolStripMenuItem();
            menuProductList = new ToolStripMenuItem();
            kategoriYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuNewCategory = new ToolStripMenuItem();
            menuCategoryList = new ToolStripMenuItem();
            tedarikçiYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuSupplierCreate = new ToolStripMenuItem();
            menuSupplierList = new ToolStripMenuItem();
            menuShipper = new ToolStripMenuItem();
            menuShipperCreate = new ToolStripMenuItem();
            nakliyecileriListeleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem, kategoriYönetimiToolStripMenuItem, tedarikçiYönetimiToolStripMenuItem, menuShipper });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniSiparişToolStripMenuItem });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 20);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // yeniSiparişToolStripMenuItem
            // 
            yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            yeniSiparişToolStripMenuItem.Size = new Size(133, 22);
            yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            yeniSiparişToolStripMenuItem.Click += yeniSiparişToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNewProduct, menuProductList });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 20);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuNewProduct
            // 
            menuNewProduct.Name = "menuNewProduct";
            menuNewProduct.Size = new Size(140, 22);
            menuNewProduct.Text = "Yeni Ürün";
            menuNewProduct.Click += menuNewProduct_Click;
            // 
            // menuProductList
            // 
            menuProductList.Name = "menuProductList";
            menuProductList.Size = new Size(140, 22);
            menuProductList.Text = "Tüm Ürünler";
            menuProductList.Click += menuProductList_Click;
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNewCategory, menuCategoryList });
            kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            kategoriYönetimiToolStripMenuItem.Size = new Size(116, 20);
            kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi ";
            // 
            // menuNewCategory
            // 
            menuNewCategory.Name = "menuNewCategory";
            menuNewCategory.Size = new Size(158, 22);
            menuNewCategory.Text = "Yeni Kategori";
            menuNewCategory.Click += menuNewCategory_Click;
            // 
            // menuCategoryList
            // 
            menuCategoryList.Name = "menuCategoryList";
            menuCategoryList.Size = new Size(158, 22);
            menuCategoryList.Text = "Tüm Kategoriler";
            menuCategoryList.Click += menuCategoryList_Click;
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            tedarikçiYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSupplierCreate, menuSupplierList });
            tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            tedarikçiYönetimiToolStripMenuItem.Size = new Size(115, 20);
            tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi";
            // 
            // menuSupplierCreate
            // 
            menuSupplierCreate.Name = "menuSupplierCreate";
            menuSupplierCreate.Size = new Size(172, 22);
            menuSupplierCreate.Text = "Tedarikçi Ekle";
            menuSupplierCreate.Click += menuSupplierCreate_Click;
            // 
            // menuSupplierList
            // 
            menuSupplierList.Name = "menuSupplierList";
            menuSupplierList.Size = new Size(172, 22);
            menuSupplierList.Text = "Tedarikçileri Listele";
            menuSupplierList.Click += menuSupplierList_Click;
            // 
            // menuShipper
            // 
            menuShipper.DropDownItems.AddRange(new ToolStripItem[] { menuShipperCreate, nakliyecileriListeleToolStripMenuItem });
            menuShipper.Name = "menuShipper";
            menuShipper.Size = new Size(117, 20);
            menuShipper.Text = "Nakliyeci Yönetimi";
            // 
            // menuShipperCreate
            // 
            menuShipperCreate.Name = "menuShipperCreate";
            menuShipperCreate.Size = new Size(180, 22);
            menuShipperCreate.Text = "Nakliyeci Ekle";
            menuShipperCreate.Click += menuShipperCreate_Click;
            // 
            // nakliyecileriListeleToolStripMenuItem
            // 
            nakliyecileriListeleToolStripMenuItem.Name = "nakliyecileriListeleToolStripMenuItem";
            nakliyecileriListeleToolStripMenuItem.Size = new Size(180, 22);
            nakliyecileriListeleToolStripMenuItem.Text = "Nakliyecileri Listele";
            nakliyecileriListeleToolStripMenuItem.Click += nakliyecileriListeleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 554);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem yeniSiparişToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuNewProduct;
        private ToolStripMenuItem menuProductList;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuNewCategory;
        private ToolStripMenuItem menuCategoryList;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuSupplierCreate;
        private ToolStripMenuItem menuSupplierList;
        private ToolStripMenuItem menuShipper;
        private ToolStripMenuItem menuShipperCreate;
        private ToolStripMenuItem nakliyecileriListeleToolStripMenuItem;
    }
}