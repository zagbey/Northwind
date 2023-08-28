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
    public partial class EmployeeUpdateForm : Form
    {
        private readonly EmployeesRepository _empRepo = new EmployeesRepository();
        private int _employeeId;
        public EmployeeUpdateForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            FillMangerComboBox();
            var employees = _empRepo.Find(_employeeId);
            if (employees != null)
            {
                txtFirstName.Text = employees.FirstName;
                txtLastName.Text = employees.LastName;
                txtTitle.Text = employees.Title;
                txtTitleOfCourtesy.Text = employees.TitleOfCourtesy;
                dtpBirtDate.Value = employees.BirthDate ?? DateTime.Today;// mtextbox versiyonu mtxtbrithDATE=employee.BirdthDate?.ToString("dd/MM/yyyy") olarak yapıyoruz
                dtpHireDate.Value = employees.HireDate ?? DateTime.Today;
                txtAdress.Text = employees.Address;
                txtCity.Text = employees.City;
                txtPostalCode.Text = employees.PostalCode;
                txtCountry.Text = employees.Country;
                txtHomePhone.Text = employees.HomePhone;
                txtExtension.Text = employees.Extension;
                txtNote.Text = employees.Notes;
                txtRegion.Text = employees.Region;


            }

        }

        private void FillMangerComboBox()
        {
            cmbManager.DataSource = _empRepo.GetAll();
            cmbManager.DisplayMember = "FullName";
            cmbManager.ValueMember = "EmployeeID";
            cmbManager.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employees = new Employees()
            {
                EmployeeID = _employeeId,
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = dtpBirtDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                Notes = txtNote.Text,
                ReportsTo = (int?)cmbManager.SelectedValue,

            };
            var result = _empRepo.Update(employees);
            if (result)
            {
                MessageBox.Show("güncelleme başarılı");
            }
            else
            {
                MessageBox.Show("güncelleme başarısız");
            }
            foreach (var form in MdiParent.MdiChildren)
            {
                if(form is EmployeeListForm)
                {
                    var employeeListForm = (EmployeeListForm)form;
                    employeeListForm.LoadEmployeesData();
                }
            }

        }
    }
}
