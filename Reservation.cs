using System;

namespace HotelLibrary
{
    public class Reservation
    {
        public int CustomerId { get; }
        public int ReservationId { get; }
        public int RoomNumber { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Reservation(int customerId, int roomNumber, DateTime startDate, DateTime endDate)
        {
            this.RoomNumber = roomNumber;
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}