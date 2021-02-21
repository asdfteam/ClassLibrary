using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLibrary
{
    [Table("CustomerReservations")]
    public class CustomerReservation
    {

        [Column("customerId")]
        public int CustomerId { get; set; }
        [Key]
        [Column("reservationId")]
        public int ReservationId { get; set; }
        [Column("roomNumber")]
        public int roomNumber { get; set; }

        public CustomerReservation() { }
    }
}
