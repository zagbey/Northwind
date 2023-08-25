using NorthwindProject.DataAccess;
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

    public partial class SupplierCreateForm : Form
    {
        SupplierRepository _supRepo = new SupplierRepository();
        public SupplierCreateForm()
        {
            InitializeComponent();
        }

        private void SupplierCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supliers = new Supplier()
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,

            };
            var result = _supRepo.Add(supliers);
            if (result)
            {
                MessageBox.Show("tedarikçi ekleme başarılı");
            }
            else
            {
                MessageBox.Show("tedarikçi ekleme başarısız");
            }

        }
    }
}
