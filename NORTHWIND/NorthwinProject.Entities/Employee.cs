using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwinProject.Entities
{
    public class Employee
    {
        //POCO: Plain old CLR/C# Object get set metoduyla yapılmış sınıflar 
        //DTO data transfer objeckt 
        //DDO (Domain Driven Desing) yaklaşımında entity nesnelerde aşağıdaki gibi

        //veri ile baraber Davranışlar (BEHAVİOR) bulunur
        //public void Hire(string title, DateTime date)
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }

 
        public byte[] Photo { get; set; }


    }
}
