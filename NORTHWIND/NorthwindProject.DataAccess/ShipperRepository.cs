using Dapper;
using NorthwinProject.Entities;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NorthwindProject.DataAccess
{
    public class ShipperRepository
    {
        public List<Shipper> GetAll()
        {

            const string sqlText = "select * from Shippers";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var shipperList = conn.Query<Shipper>(sqlText).ToList();
                    return shipperList;
                }

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Shipper> { };
            }
        }
        public bool Update(Shipper shipper)
        {

            const string updateShippers = @"
update Shippers 
set 
  [CompanyName]=@CompanyName,
  [Phone]=@Phone
 WHERE ShipperID=@ShipperID

";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(updateShippers, shipper);
                    return affectedRows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }

        }
        public Shipper Find(int shipperId)
        {
            try
            {
                const string sqlQuery = @"select * from Shippers where ShipperID=@ShipperID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var shipper = conn.QuerySingleOrDefault<Shipper>(sqlQuery, new { shipperId });
                    return shipper;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Add(Shipper shipper)
        {
            const string addShipper = @"
insert into Shippers (
   CompanyName,
   Phone)
values (@CompanyName,@Phone)";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(addShipper, shipper);
                    return affectedRows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;

            }
        }
        public bool Remove(Shipper shipper)
        {
            try
            {
                const string selectedShipper = "Delete from Shippers where ShipperID=@ShipperID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(selectedShipper, shipper);
                    return affectedRows > 0;
                }

            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());

                return false;
            }

        }
        public bool Remove(int shipperId)
        {
            var shipper = new Shipper()
            {
                ShipperID = shipperId
            };
            return Remove(shipper);
        }
    }

}
