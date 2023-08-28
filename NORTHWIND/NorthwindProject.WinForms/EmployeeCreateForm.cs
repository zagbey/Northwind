using NorthwindProject.DataAccess;
using NorthwinProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindProject.WinForms
{
    public partial class EmployeeCreateForm : Form
    {
        private readonly EmployeesRepository _empRepo = new EmployeesRepository();
        public EmployeeCreateForm()
        {
            InitializeComponent();
        }

        private void EmployeeCreateForm_Load(object sender, EventArgs e)
        {
            var allemployees = _empRepo.GetAll();
            cmbManager.DataSource = allemployees;
            cmbManager.ValueMember = "EmployeeID";
            cmbManager.DisplayMember = "FullName";

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //entity nesneyi oluştur
            var employee = new Employees()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                //gelişmiş DateTimePicker kontrollerine ihtiyacımız var 
                //telerik,DevExpress,ComponentOne,SyncFusion    bunları araştır 
                //dateTime picker null geçmiyor ama direkt value ile alıyor 
                BirthDate = dtpBirtDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                Notes=txtNote.Text,
                ReportsTo = (int?)cmbManager.SelectedValue, // burası combobox olacak 
                
            };
            //bu nesneyi işi yapacak olan (repository / service,Manager)
            //işçi nesnenin ilgili metoduna (add,update vs )gönder 
            var result = _empRepo.Add(employee);
            if (result)
            {
                MessageBox.Show("çalışan ekleme başaralı");
            }
            else
            {
                MessageBox.Show("çalışan ekleme başarısız");
                
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
