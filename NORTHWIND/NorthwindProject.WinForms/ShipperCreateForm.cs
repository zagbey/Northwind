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
    public partial class ShipperCreateForm : Form
    {
        ShipperRepository _shipRepo = new ShipperRepository();
        public ShipperCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone = txtPhone.Text,
            };
            var result = _shipRepo.Add(shipper);
            MessageBox.Show(result?"işlem başarılı":"ekleme başarısız");

        }
    }
}
