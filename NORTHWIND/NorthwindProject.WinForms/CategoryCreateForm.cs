using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
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
    public partial class CategoryCreateForm : Form
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void CategorryCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtDescription.Text;

            var result = _categoryRepository.Add(category);

            if (result)
            {
                MessageBox.Show("ilem başarıyla gerçekelşti");
            }
            else
            {
                MessageBox.Show("başarısız işlem");
            }

        }
    }
}
