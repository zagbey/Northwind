using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
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
    public partial class SupplierListForm : Form

    {
        private readonly SupplierRepository _supplierRepo = new SupplierRepository();
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) //e. den left mi frıght mı clickle alaklı verileri alıyoruz 
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void SuppliersListForm_Load(object sender, EventArgs e)
        {
            var supRepo = new SupplierRepository();
            List<Supplier> suppliers = supRepo.Getall();
            dataGridView1.DataSource = suppliers;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // seçili bir satır var mı 
            {
                var deleteSuppliers = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem; // her bir satıra bağlanmış ıtem obje olarak bağlıyor
                bool result = _supplierRepo.Remove(deleteSuppliers);

                if (result)
                {
                    MessageBox.Show("kategori silindi");
                }
                else
                {
                    MessageBox.Show("kategori silinemedi");
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suppliers = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
            var supliersUpdate = new SupplierUpdateForm(suppliers.SupplierID);
            supliersUpdate.Show();
        }
    }
}
