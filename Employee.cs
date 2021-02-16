﻿namespace HotelLibrary
{

    public delegate void ChangeRoomStatus(Room room);
    public class Employee
    {
        public int Id { get; set; }
        public EmployeeType EmployeeType { get; set;  }
        public Employee(EmployeeType type) => this.EmployeeType = type;

    }

    public enum EmployeeType
    {
        FrontDeskWorker,
        Cleaner,
        Maintainer,
        ServiceWorker
    }
}