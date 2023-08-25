namespace NorthwindProject.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yeniSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderCreateForm = new OrderCreateForm();
            orderCreateForm.MdiParent = this;
            orderCreateForm.Show();
        }

        private void menuNewProduct_Click(object sender, EventArgs e)
        {
            var product = new ProductCreateForm();
            product.MdiParent = this;
            product.Show();
        }

        private void menuProductList_Click(object sender, EventArgs e)
        {
            var productList = new ProductListForm();
            productList.MdiParent = this;
            productList.Show();
        }

        private void menuNewCategory_Click(object sender, EventArgs e)
        {
            var category = new CategoryCreateForm();
            category.MdiParent = this;
            category.Show();
        }

        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            var categoryList = new CategoryListForm();
            categoryList.MdiParent = this;
            categoryList.Show();
        }

        private void menuSupplierCreate_Click(object sender, EventArgs e)
        {
            var supplierAdd = new SupplierCreateForm();
            supplierAdd.MdiParent = this;
            supplierAdd.Show();
        }

        private void menuSupplierList_Click(object sender, EventArgs e)
        {
            var suppliersList = new SupplierListForm();
            suppliersList.MdiParent = this;
            suppliersList.Show();
        }
    }
}