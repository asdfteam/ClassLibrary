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
        public int ReservationId { get; set; }
        [ForeignKey("customerId")]
        public Customer Customer { get; set; }

        [ForeignKey("roomNumber")]
        public Room Room { get; set; }
        [Column("startDate")]
        public DateTime StartDate { get; set; }
        [Column("endDate")]
        public DateTime EndDate { get; set; }

        public Reservation() { }
    }
}