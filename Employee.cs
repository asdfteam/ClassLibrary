using System.ComponentModel.DataAnnotations;

namespace HotelLibrary
{

    public delegate void ChangeRoomStatus(Room room);
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public EmployeeType EmployeeType { get; set;  }
        public Employee(EmployeeType type) => EmployeeType = type;

    }

    public enum EmployeeType
    {
        FrontDeskWorker,
        Cleaner,
        Maintainer,
        ServiceWorker
    }
}