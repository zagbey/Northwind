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
    public class CustomersRepository
    {
        public List<Customer> Getall()
        {
            const string sqlText = "select * from Customers";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var customerList = conn.Query<Customer>(sqlText).ToList();
                    return customerList;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return new List<Customer> { };
            }
        }
        public Customer Find(string customerId)
        {
            const string sqlText = "select * from Customers where CustomerID=@customerId";
            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var customers = sqlConn.QuerySingleOrDefault<Customer>(sqlText, new { customerId });//sorgu sonucunu kategoriye maple <Category>
                    //QuerySingleOrDefaolut veri tabanından tek bir satır halinde verleri çekmeye yarıyor
                    return customers;
                }


            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return null;

            }
        }

        public bool Update(Customer customer)
        {
            const string updateCustomer = @"

UPDATE Customers
   SET CustomerID =@CustomerID,
       CompanyName =@CompanyName,
       ContactName =@ContactName,
       ContactTitle =@ContactTitle,
       Address = @Address,
       City = @City,
       Region = @Region,
       PostalCode =@PostalCode,
       Country =@Country,
       Phone =@Phone,
       Fax =@Fax
 WHERE CustomerID=@CustomerID

";
            try
            {
                using (var conn =new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(updateCustomer, customer);
                    return affectedRows > 0;
                }
            }
            catch (Exception ec)
            {

                Trace.TraceError(ec.ToString());
                return false;
            }
        }
        public bool Add(Customer customers)
        {
            const string sqlQuery = @"insert into Customers (
           CustomerID,
           CompanyName,
           ContactName,
           ContactTitle,
           Address,
           City,
           Region,
           PostalCode,
           Country,
           Phone,
           Fax)
values 
           (
           @CustomerID,
           @CompanyName,
           @ContactName,
           @ContactTitle,
           @Address,
           @City,
           @Region,
           @PostalCode,
           @Country,
           @Phone,
           @Fax)

";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affacetedRows = conn.Execute(sqlQuery, customers);
                    return affacetedRows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }

        }
        public bool Remove(Customer customers)
        {
            try
            {
                const string selectedCustomers = "Delete from Customers where CustomerID=@CustomerID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(selectedCustomers, customers);
                    return affectedRows > 0;
                }

            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());

                return false;
            }
        }
        public bool Remove(string customerId)
        {
            var customers = new Customer()
            {
                CustomerID = customerId
            };
        return Remove(customers);
        }
    }
}
