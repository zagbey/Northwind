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
    public partial class CategoryUpdateForm : Form
    {
        private int _categoryid;
        public CategoryUpdateForm(int CategoryId)
        {

            InitializeComponent();
            _categoryid = CategoryId;
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            var repostry = new CategoryRepository();
            var category = repostry.Find(_categoryid);
            if (category != null)
            {
                txtCategoryName.Text = category.CategoryName;
                txtDescription.Text = category.Description;
                textBox1.Text = category.CategoryID.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.CategoryID = _categoryid;
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtDescription.Text;

            var repostry = new CategoryRepository();
            repostry.Update(category);
        }
    }
}
