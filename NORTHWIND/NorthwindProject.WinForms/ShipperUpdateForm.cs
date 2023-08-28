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
    public partial class ShipperUpdateForm : Form
    {
        private readonly ShipperRepository _shipRepo = new ShipperRepository();
        private int _shipperId;
        public ShipperUpdateForm(int shipperId)
        {
            InitializeComponent();
            _shipperId = shipperId;
        }

        private void ShipperUpdateForm_Load(object sender, EventArgs e)
        {
            var shippers = _shipRepo.Find(_shipperId);
            if (shippers != null)
            {
                txtCompanyName.Text = shippers.CompanyName;
                txtPhone.Text = shippers.Phone;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone = txtPhone.Text,
            };

            var result =_shipRepo.Update(shipper);
            MessageBox.Show(result?"Güncelleme başarılı":"Güncelleme başarısız");
        }
    }
}
