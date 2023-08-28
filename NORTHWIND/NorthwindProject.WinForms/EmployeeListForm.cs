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
    public partial class EmployeeListForm : Form
    {
        private readonly EmployeesRepository _employeesRepository = new EmployeesRepository();
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            //var empRepo = new EmployeesRepository();
            //List<Employees> employees = empRepo.GetAll();
            //dataGridView1.DataSource = employees;
            LoadEmployeesData();
        }
        public void LoadEmployeesData()
        {
            dataGridView1.DataSource = _employeesRepository.GetAll();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // satır seçilmiş mi
            {
                var deleteEmployee = (Employees)dataGridView1.SelectedRows[0].DataBoundItem;
                bool result = _employeesRepository.Remove(deleteEmployee);

                if (result)
                {
                    MessageBox.Show("ürün silindi");
                }
                else
                {
                    MessageBox.Show("ürün silinemdi");
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = (Employees)dataGridView1.SelectedRows[0].DataBoundItem;
            if (employee != null)
            {
                var employeeUpdate = new EmployeeUpdateForm(employee.EmployeeID);
                employeeUpdate.MdiParent = this.MdiParent;
                employeeUpdate.Show();
            }
        }
    }
}
