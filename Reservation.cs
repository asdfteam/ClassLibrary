using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLibrary
{
    public class Reservation
    {
        [ForeignKey("customer_id")]
        public int CustomerId { get; }
        [Key]
        public int ReservationId { get; }
        [ForeignKey("roomNumber")]
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