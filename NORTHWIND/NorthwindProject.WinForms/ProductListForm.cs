using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
using NorthwinProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindProject.WinForms
{
    public partial class ProductListForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var productRepo = new ProductRepository();
            List<Product> product = productRepo.Getall();
            dataGridView1.DataSource = product;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var product = (Product)dataGridView1.SelectedRows[0].DataBoundItem;

            var productUpdate = new ProductUpdateForm(product.ProductID);
            productUpdate.MdiParent = this.MdiParent;
            productUpdate.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // satır seçilmiş mi
            {
                var deleteProduct = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
                bool result =_productRepository.Remove(deleteProduct);

                if (result)
                {
                    MessageBox.Show("ürün silindi");
                }
                else
                {
                    MessageBox.Show("ürün silinemdi");
                }
            }
        }
    }
}
