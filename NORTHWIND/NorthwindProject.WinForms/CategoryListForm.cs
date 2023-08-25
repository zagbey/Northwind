using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindProject.Entities;
using NorthwindProject.DataAccess;
using NorthwinProject.Entities;

namespace NorthwindProject.WinForms
{
    
    public partial class CategoryListForm : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.Getall();
            dataGridView1.DataSource = categories;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) //e. den left mi frıght mı clickle alaklı verileri alıyoruz 
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = (Category)dataGridView1.SelectedRows[0].DataBoundItem;

            var categoryUpdate = new CategoryUpdateForm(category.CategoryID);
            categoryUpdate.MdiParent = this.MdiParent;
            categoryUpdate.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // seçili bir satır var mı 
            {
                var deleteCategory = (Category)dataGridView1.SelectedRows[0].DataBoundItem; // her bir satıra bağlanmış ıtem obje olarak bağlıyor
               bool result = _categoryRepository.Remove(deleteCategory);

                if (result)
                {
                    MessageBox.Show("kategori silindi");
                }
                else
                {
                    MessageBox.Show("kategori silinemedi");
                }
            }

        }
    }
}
