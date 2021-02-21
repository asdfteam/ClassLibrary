using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelLibrary
{
    [Table("Rooms")]
    public class Room
    {   
        [Column("roomNumber")]
        [Key]
        public int RoomNumber { get; set; }
        [Column("roomStatus")]
        public string RoomStatus { get; set; }
        [Column("singleBed")]
        public int SingleBed { get; set; }
        [Column("doubleBed")]
        public int DoubleBed { get; set; }
        [Column("note")]
        public string Note { get; set; }

        public Room()
        {

        }
    }
}