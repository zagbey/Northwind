using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.WinForms.ViewModels
{
    //arayüze hizmet eden normal şartlarda veri tabanından gelmeyen verileri daha detaylı göstermek için oluşturuğumuz model 
    public class OrderDetailInputModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public decimal GrossAmount
        {
            get
            {
                return UnitPrice * Quantity; // İndirim uygulanmamış tutar
            }
        }
        public decimal NetAmount
        {
            get
            {
                return GrossAmount * (1 - (decimal)Discount);
            }
        }
    }
}
