using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLibrary
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        [Column("reservationId")]
        public int ReservationId { get; }
        [ForeignKey("customer_id")]
        [Column("customerId")]
        public int CustomerId { get; }

        [ForeignKey("roomNumber")]
        [Column("roomNumber")]
        public int RoomNumber { get; }
        [Column("startDate")]
        public DateTime StartDate { get; set; }
        [Column("endDate")]
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