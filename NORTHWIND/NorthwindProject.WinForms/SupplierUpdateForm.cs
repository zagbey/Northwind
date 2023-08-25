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

    public partial class SupplierUpdateForm : Form
    {
        private readonly SuppliersRepository _supplierRepo = new SuppliersRepository();
        private int _supplier;
        public SupplierUpdateForm(int supplier)
        {
            InitializeComponent();
            _supplier = supplier;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Suppliers()
            {
                SupplierID = _supplier,
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                ContactTitle=txtContactTitle.Text,
                Address=txtAdress.Text,
                City=txtCity.Text,
                Region=txtRegion.Text,
                PostalCode=txtPostalCode.Text,
                Country=txtCountry.Text,
                Phone=txtPhone.Text,
                Fax=txtFax.Text,
                HomePage=txtHomePage.Text,
            };
            var result = _supplierRepo.Update(supplier);
            MessageBox.Show(result?"tedarikçi güncelleme başarılı":"tedarikçi güncelleme başarısız");
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            var supliers = _supplierRepo.Find(_supplier);
            if(supliers != null)
            {
                txtCompanyName.Text = supliers.CompanyName;
                txtContactTitle.Text = supliers.ContactTitle;
                txtContactName.Text = supliers.ContactName;
                txtAdress.Text = supliers.Address;
                txtCity.Text = supliers.City;
                txtRegion.Text = supliers.Region;
                txtPostalCode.Text = supliers.PostalCode;
                txtCountry.Text = supliers.Country;
                txtPhone.Text = supliers.Phone;
                txtFax.Text = supliers.Fax;
                txtHomePage.Text = supliers.HomePage;
            }
        }
    }
}
