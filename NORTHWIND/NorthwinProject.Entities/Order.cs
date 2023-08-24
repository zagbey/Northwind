using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwinProject.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int OrderID { get; set; }
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }


        //neden set yok ?
        //yazdığımız sınıfta koleksiyon varsa bu mutlaka bu koleksiyonu constructorda initialize et yani instanceyi al 
        //dışardan kullanıma hazır olmalı diğer türlü Null exceptionu alıyoruz
        //set kapanıyor çünkü dışardan müdehale edilmemesi gerekiyor burada instaceyi alıyoruz 
        //fakat dışardan null değer atanıyor aynı hatayı tekrar almamıza sebep oluyor 
        //orderDetails=...... kapatıyoruz yani referansı değiştirmeyi 

        //orderDetails.Clear(); vb durumlar kullanılabilir 
        public List<OrderDetail> OrderDetails { get; }

        ////get hali arka planda bu şekilde çalışıyor
        //private readonly List<OrderDetail> _orderDetails;
        //public List<OrderDetail> OrderDetails
        //{
        //    get
        //    {
        //        return _orderDetails;
        //    }
        //}
    }
}
