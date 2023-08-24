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

    public partial class OrderCreateForm : Form
    {
        private readonly OrderRepository _orderRepository = new OrderRepository();
        private List<OrderDetailInputModel> _orderDetailList = new List<OrderDetailInputModel>();
        private readonly CustomersRepository _customerRepo = new CustomersRepository();
        private readonly EmployeesRepository _employeesRepo = new EmployeesRepository();
        private readonly CategoryRepository _categoryRepo = new CategoryRepository();//readonly constructor dışında değeri değişmeyecek
        public OrderCreateForm()
        {
            InitializeComponent();
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {

            cmbCustomerID.DataSource = _customerRepo.Getall();
            cmbCustomerID.DisplayMember = "CompanyName";
            cmbCustomerID.ValueMember = "CustomerID";
            cmbCustomerID.SelectedIndex = -1;

            cmbEmployeeID.DataSource = _employeesRepo.GetAll();
            cmbEmployeeID.DisplayMember = "FullName";
            cmbEmployeeID.ValueMember = "EmployeeID";
            cmbEmployeeID.SelectedIndex = -1;


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //modal 
            var orderDetailEditForm = new OrderDetailEditForm();

            //event listenig 
            orderDetailEditForm.OrderDetailCreated += OrderDetailCreatedMethod; //event meydana gelirse bu metodu kullan

            //gerektiği takdirde bir event'e fazla listener metod baglanabilir


            orderDetailEditForm.ShowDialog();
        }

        //event handling 
        private void OrderDetailCreatedMethod(OrderDetailInputModel orderDetail)
        {
            //benim bu metodum çaıştığında biliyorum ki diğer Form'da 
            //OrderDetail nesnesi hazır hale geldi 
            _orderDetailList.Add(orderDetail);
            gridOrderDetails.DataSource = null;//kendini refresh etmesi için yapıyoruz trick yöntem
            gridOrderDetails.DataSource = _orderDetailList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//datetimepicekrlerden null değer alınmıyor !

            //Entity nesneyi oluştur 
            var order = new Order();
            order.CustomerID = (string)cmbCustomerID.SelectedValue;
            order.EmployeeID = (int?)cmbEmployeeID.SelectedValue;
            order.OrderDate = dtpOrderDate.Value;
            order.RequiredDate = dtpRequaredDate.Value;
            order.ShippedDate = dtpShippedDate.Value;
            order.ShipVia = (int?)cmbShıpVia.SelectedValue;
            order.Freight = nmrFreight.Value;
            order.ShipName = txtShipName.Text;
            order.ShipCountry = txtShipCountry.Text;
            order.ShipCity = txtShipCity.Text;
            order.ShipAddress = txtShipAdress.Text;
            order.ShipRegion = txtShipRegion.Text;
            order.ShipPostalCode = txtShipPostalCode.Text;

            foreach (var detailInput in _orderDetailList)
            {
                //her adımda OrderDetailInputModel tipinde olan nesneyi 
                //OrderDetail entity nesnesine Maplemem lazım 
                var orderDetailEntity = new OrderDetail()
                {
                    ProductID = detailInput.ProductID,
                    UnitPrice = detailInput.UnitPrice,
                    Quantity = detailInput.Quantity,
                    Discount = detailInput.Discount
                };
                order.OrderDetails.Add(orderDetailEntity);

                //FOREACH E ALTERNATİF order.OrderDetails.AddRange(_orderDetailsList);

            }
            var result = _orderRepository.Add(order);

            MessageBox.Show(result ? "sipariş başarıyla oluşturuldu" : "sipariş oluşturulamadı");
        }
    }
}
