using NorthwindProject.DataAccess;
using NorthwindProject.WinForms.ViewModels;
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
    public partial class OrderDetailEditForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        public OrderDetailEditForm()
        {
            InitializeComponent();
        }
        public delegate void OrderDetailCreatedHnadler(OrderDetailInputModel orderDetail);
        public event OrderDetailCreatedHnadler OrderDetailCreated;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1)
            {
                var product = (Product)cmbProduct.SelectedItem;
                txtUnitPrice.Text = product.UnitPrice?.ToString("N2"); // N2 virgülden sonra 2 değer alıyor 

            }
            else
            {
                txtUnitPrice.Text = string.Empty;//seçili değişince fiyatı güncellensin
            }
        }

        private void OrderDetailEditForm_Load(object sender, EventArgs e)
        {
            var allProducts = _productRepository.Getall();
            cmbProduct.DataSource = allProducts;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            var orderDetalInput = new OrderDetailInputModel();
            orderDetalInput.ProductID = (int)cmbProduct.SelectedValue;
            orderDetalInput.ProductName = cmbProduct.Text;

            if(decimal.TryParse(txtUnitPrice.Text,out decimal unitPrice))
            {
                orderDetalInput.UnitPrice=unitPrice;
            }
            orderDetalInput.Quantity = (short)numQuantity.Value;
            orderDetalInput.Discount = (float)numDiscount.Value/100;



            //event fire (olayı fırlatmak)
            //NullReferenceException hatası almamak adına
            //OrderDetailCreated(orderDetailInput); // alltaki hali daha kullanışlı
            OrderDetailCreated?.Invoke(orderDetalInput);
            
        }
    }
}
