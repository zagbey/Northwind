using Dapper;
using NorthwinProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess
{
    public class OrderRepository
    {
        public List<Order> GetAll()
        {
            return new List<Order>();
        }
        public bool Add(Order order)
        {
            const string orderInsertSql = @"
INSERT INTO [dbo].[Orders]
           ([CustomerID]
           ,[EmployeeID]
           ,[OrderDate]
           ,[RequiredDate]
           ,[ShippedDate]
           ,[ShipVia]
           ,[Freight]
           ,[ShipName]
           ,[ShipAddress]
           ,[ShipCity]
           ,[ShipRegion]
           ,[ShipPostalCode]
           ,[ShipCountry])
     VALUES
           (@CustomerID
           ,@EmployeeID
           ,@OrderDate
           ,@RequiredDate
           ,@ShippedDate
           ,@ShipVia
           ,@Freight
           ,@ShipName
           ,@ShipAddress
           ,@ShipCity
           ,@ShipRegion
           ,@ShipPostalCode
           ,@ShipCountry)
SELECT @@IDENTITY ";

            const string orderDetailInsertSql = @"
INSERT INTO [dbo].[Order Details]
           ([OrderID]
           ,[ProductID]
           ,[UnitPrice]
           ,[Quantity]
           ,[Discount])
     VALUES
           (@OrderID
           ,@ProductID
           ,@UnitPrice
           ,@Quantity
           ,@Discount)
";

            //Order Details tablosunda ıdentity key yok  order ve productId de kendim söylemeliyim  
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var orderId = conn.ExecuteScalar<int>(orderInsertSql, order);  //insert ettiği anda scalar değeri okuyabilmek adına ExecuteScalar kullanıldı
                    foreach (var orderDetail in order.OrderDetails)                //execute affectedRows döndürür  
                    {                                                              //ExecuteScalar select @@identity  ile int e mapliyoruz 
                        orderDetail.OrderID = orderId;
                        conn.Execute(orderDetailInsertSql, orderDetail);

                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());

                return false;
            }
        }
    }
}
