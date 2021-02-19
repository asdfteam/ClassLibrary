using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLibrary
{
    public class Employee
    {
        [Key]
        [Column("employeeId")]
        public int EmployeeId { get; set; }
        [Column("employeeType")]
        public string EmployeeType { get; set;  }
        public Employee() { }
    }
}