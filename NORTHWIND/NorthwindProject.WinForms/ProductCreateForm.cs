using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindProject.DataAccess;
using NorthwinProject.Entities;

namespace NorthwindProject.WinForms
{
    public partial class ProductCreateForm : Form
    {
        ProductRepository _proRepo = new ProductRepository();
        SuppliersRepository _supRepo = new SuppliersRepository();
        public ProductCreateForm()
        {
            InitializeComponent();
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.Getall();

            cmbCategoryID.DataSource = categories;
            cmbCategoryID.DisplayMember = "CategoryName";
            cmbCategoryID.ValueMember = "CategoryID";
            cmbCategoryID.SelectedValue = -1;

            var suppliers = _supRepo.Getall();
            cmbSuplierID.DataSource = suppliers;
            cmbSuplierID.DisplayMember = "CompanyName";
            cmbSuplierID.ValueMember = "SupplierID";
            cmbSuplierID.SelectedValue = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductName = txtProductName.Text,
                //categoryıd
                CategoryID = (int?)cmbCategoryID.SelectedValue, //kullanıcı string değeri görüp seçtiğinde benim için Id değerini seçmiş oluyo 
                                                                //bizim için ıd seçmiş oluyo bunun sebebi displayMember = categoryId
                                                                
                SupplierID = (int?)cmbSuplierID.SelectedValue,
                QuantityPerUnit = txtQuantitiyPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInstock = !string.IsNullOrWhiteSpace(txtUnitInStock.Text)
                ? short.Parse(txtUnitInStock.Text)
                : default,
                UnitsOnOrder = !string.IsNullOrWhiteSpace(txtUnistInOrder.Text)
                ? short.Parse(txtUnistInOrder.Text)
                : default(short?),
                ReorderLevel = !string.IsNullOrWhiteSpace(txtReorderLevel.Text)
                ? short.Parse(txtReorderLevel.Text)
                : default(short?),
                Discontinued = !chkIsActive.Checked,


            };
            var result = _proRepo.Add(product);
            MessageBox.Show(result?"Ürün ekleme başarılı":"Ürün ekleme başarısız");
        }
    }
}
