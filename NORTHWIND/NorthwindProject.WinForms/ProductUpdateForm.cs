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
using System.Net.WebSockets;

namespace NorthwindProject.WinForms
{
    public partial class ProductUpdateForm : Form
    {
        private readonly ProductRepository _productRepo = new ProductRepository();
        private readonly CategoryRepository _categoryRepo = new CategoryRepository();
        private readonly SupplierRepository _supplierRepo = new SupplierRepository();
        private int _product;
        public ProductUpdateForm(int productId)
        {

            InitializeComponent();
            _product = productId;
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {

            
            var product = _productRepo.Find(_product);
            if (product != null)
            {
                txtProductName.Text = product.ProductName;
                if (product.CategoryID.HasValue)
                    cmbCategoryID.SelectedValue = product.CategoryID;

                if (product.SupplierID.HasValue)
                    cmbSuplierID.SelectedValue = product.SupplierID;

                txtQuantitiyPerUnit.Text = product.QuantityPerUnit;
                numUnitPrice.Value = product.UnitPrice ?? default;

                txtUnitInStock.Text = product.UnitsInstock?.ToString();
                txtUnistInOrder.Text = product.UnitsOnOrder?.ToString();
                txtReorderLevel.Text = product.ReorderLevel?.ToString();
                chkIsActive.Checked = !product.Discontinued;

            }

            
            cmbCategoryID.DataSource = _categoryRepo.Getall();
            cmbCategoryID.DisplayMember = "CategoryName";
            cmbCategoryID.ValueMember = "CategoryID";  //neyi değer olarak kabul edecek 

            cmbSuplierID.DataSource=_supplierRepo.Getall();
            cmbSuplierID.DisplayMember = "CompanyName";
            cmbSuplierID.ValueMember = "SupplierID";
            //var suppliers = new Suppliers();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductID = _product,
                ProductName = txtProductName.Text,
                CategoryID = (int?)cmbCategoryID.SelectedValue,
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

            _productRepo.Update(product);
        }
    }
}
