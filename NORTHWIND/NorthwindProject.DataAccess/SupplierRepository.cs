using Dapper;
using NorthwindProject.Entities;
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
    public class SupplierRepository
    {
        public List<Supplier> Getall()
        {

            const string sqlText = "select * from Suppliers";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var suppliersList = conn.Query<Supplier>(sqlText).ToList();
                    return suppliersList;
                }

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Supplier> { }; //boş bir listeyi temsil etmek için yaptık 
                                                //null değer değil de bunun yerine boş bir liste çeviriyoruz 
            }

        }
        public bool Update(Supplier supplier)
        {

            const string supplierQueru = @"
update Suppliers
set  
   CompanyName=@CompanyName,
   ContactName=@ContactName,
   ContactTitle=@ContactTitle,
   Address=@Address,
   City =@City,
   Region=@Region,
   PostalCode =@PostalCode,
   Country=@Country,
   Phone =@Phone,
   Fax =@Fax,
   HomePage =@HomePage
where SupplierID = @SupplierID

";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(supplierQueru, supplier);
                    return affectedRows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }

        }
        public Supplier Find(int supplierId)
        {
            try
            {
                const string sqlQuery = @"select * from Suppliers where SupplierID=@SupplierID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var suppliers = conn.QuerySingleOrDefault<Supplier>(sqlQuery,new {supplierId});
                    return suppliers;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool Add(Supplier suppliers)
        {
            const string addSupliers = @"
insert into Suppliers (
   CompanyName,
   ContactName,
   ContactTitle,
   Address,
   City,
   Region,
   PostalCode,
   Country,
   Phone,
   Fax,
   HomePage)
values (@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax,@HomePage)";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows =conn.Execute(addSupliers, suppliers);
                    return affectedRows >0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
                
            }
        }
        public bool Remove(Supplier suppliers)
        {
            try
            {
                const string selectedSuppliers = "Delete from Suppliers where SupplierID=@SupplierID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(selectedSuppliers, suppliers);
                    return affectedRows > 0;
                }

            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());

                return false;
            }

        }
        string[] GetAllTables(SqlConnection connection)
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.Tables", connection);
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                result.Add(reader["name"].ToString());
            return result.ToArray();
        }
        public bool Remove(int supplierId)
        {
            var suppliers = new Supplier()
            {
                SupplierID = supplierId
            };
            return Remove(suppliers);
        }

    }
}
