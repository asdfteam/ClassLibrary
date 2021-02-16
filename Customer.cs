using System;

namespace HotelLibrary
{
    public class Customer
    {
        public int Id { get; } 
        public string Name { get; set; }
        public Reservation Reservation { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
        public Customer(string name, Reservation reservation)
        {
            this.Name = name;
            this.Reservation = reservation;
        }
    }
}