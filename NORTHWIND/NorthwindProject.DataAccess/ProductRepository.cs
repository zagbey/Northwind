using Dapper;
using NorthwindProject.Entities;
using NorthwinProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess
{
    public class ProductRepository
    {
        private const string ConnectionString = "Server=SQLEGITIM; Database=Nortwind; User Id=sa; Password=123456789zg";
        //product List Form da oluşan kategoriyi bir Product<>list oluşturup içine atıyoruz ordan geliyo

        //veritabanındaki tüm kayıtları getir
        public List<Product> Getall()
        {
            const string sqlText = "select * from Products";
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    var productList = conn.Query<Product>(sqlText).ToList();
                    return productList;
                }

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Product> { }; //boş bir listeyi temsil etmek için yaptık 
                                               //null değer değil de bunun yerine boş bir liste çeviriyoruz 
            }

        }
        public void Update(Product product)
        {

            const string updateProduct = @"
update Products 
set 
ProductName = @ProductName,
    SupplierID = @SupplierID,
    CategoryID = @CategoryID,
    QuantityPerUnit = @QuantityPerUnit,
    UnitPrice = @UnitPrice,
    UnitsInStock = @UnitsInStock,
    UnitsOnOrder = @UnitsOnOrder,
    ReorderLevel = @ReorderLevel,
    Discontinued = @Discontinued
where ProductID = @ProductID

";
            try
            {
                using (var conn = new SqlConnection( ConnectionString))
                {
                    conn.Execute(updateProduct, product);
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
            }

        }
        public Product Find(int productId)
        {
            const string sqlText = "select * from Products where ProductID=@productId";
            try
            {
                using (var sqlConn = new SqlConnection(ConnectionString))
                {
                    var product = sqlConn.QuerySingleOrDefault<Product>(sqlText, new { productId });//sorgu sonucunu kategoriye maple <Product>
                    //QuerySingleOrDefaolut veri tabanından tek bir satır halinde verleri çekmeye yarıyor
                    return product;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());

                return null; //tekil nesneler için yukarıdakinin aksine null dur koleksiyonlarda boş bir listedir 
            }


        }

        public bool Add(Product product)
        {
            const string sqlQuery = @"
insert into Products(
            ProductName,
           SupplierID,
           CategoryID,
           QuantityPerUnit,
           UnitPrice,
           UnitsInStock,
           UnitsOnOrder,
           ReorderLevel,
           Discontinued)
values (
@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)";
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Execute(sqlQuery, product);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        public bool Remove(Product product)
        {
            try
            {
                const string selectedProductSql = "Delete from Products where ProductID=@ProductID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(selectedProductSql, product);
                    return affectedRows > 0;
                }

            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());

                return false;
            }

        }
        public bool Remove(int productId)
        {
            var product = new Product()
            {
                ProductID = productId
            };
            return Remove(product);
        }


    }
}
