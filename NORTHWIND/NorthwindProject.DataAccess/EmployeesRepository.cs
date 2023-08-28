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
    public class EmployeesRepository
    {
        public List<Employees> GetAll()
        {
            const string sqlText = "select * from Employees";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var employeesList = conn.Query<Employees>(sqlText).ToList();
                    return employeesList;
                }

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Employees> { }; //boş bir listeyi temsil etmek için yaptık 
                                              //null değer değil de bunun yerine boş bir liste çeviriyoruz 
            }

        }
        public bool Update(Employees employees)
        {

            const string updateEmployees = @"
update Employees
set 
    LastName=@LastName,
    FirstName=@FirstName,
    Title=@Title,
    TitleOfCourtesy=@TitleOfCourtesy,
    BirthDate=@BirthDate,
    HireDate =@HireDate ,
    Address=@Address,
    City=@City,
    Region=@Region,
    PostalCode=@PostalCode,
    Country=@Country,
    HomePhone=@HomePhone,
    Extension=@Extension,
    Photo=@Photo,
    Notes=@Notes,
    ReportsTo=@ReportsTo
where EmployeeID = @EmployeeID

";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows =conn.Execute(updateEmployees, employees);
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }

        }
        public Employees Find(int employeeId)
        {
            const string sqlText = "select * from Employees where EmployeeID=@employeeId";
            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var employee = sqlConn.QuerySingleOrDefault<Employees>(sqlText, new { employeeId });//sorgu sonucunu kategoriye maple <Employee>
                    //QuerySingleOrDefaolut veri tabanından tek bir satır halinde verleri çekmeye yarıyor
                    return employee;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());

                return null; //tekil nesneler için yukarıdakinin aksine null dur koleksiyonlarda boş bir listedir 
            }


        }
        public bool Add(Employees employees)
        {
            const string sqlQuery = @"insert into Employees(

    LastName,
    FirstName,
    Title,
    TitleOfCourtesy,
    BirthDate,
    HireDate,
    Address,
    City,
    Region,
    PostalCode,
    Country,
    HomePhone,
    Extension,
    Photo,
    Notes,
    ReportsTo
   )
values(
    @LastName,
    @FirstName,
    @Title,
    @TitleOfCourtesy,
    @BirthDate,
    @HireDate,
    @Address,
    @City,
    @Region,
    @PostalCode,
    @Country,
    @HomePhone,
    @Extension,
    @Photo,
    @Notes,
    @ReportsTo
    )
  ";
            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows =sqlConn.Execute(sqlQuery, new { employees });
                    return affectedRows > 0;
                }
                
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        public bool Remove(Employees employees)
        {
            try
            {
                const string sqlQuery = "Delete From Employees where EmployeeID=@EmployeeID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                   var affectedRows = conn.Execute(sqlQuery, new { employees });
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        public bool Remove(int employeeId)
        {
            var employee = new Employees()
            {
                EmployeeID = employeeId
            };
            return Remove(employee);   
        }
    }
}
