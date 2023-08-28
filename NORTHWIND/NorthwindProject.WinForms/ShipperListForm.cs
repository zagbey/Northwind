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
    public partial class ShipperListForm : Form
    {
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            var shipperRepo = new ShipperRepository();
            List<Shipper> shipper = shipperRepo.GetAll();
            dataGridView1.DataSource = shipper;
        }

        private void ShipperListForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shipper = (Shipper)dataGridView1.SelectedRows[0].DataBoundItem;

            var shipperUpdate = new ShipperUpdateForm(shipper.ShipperID);
            shipperUpdate.MdiParent = this;

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
