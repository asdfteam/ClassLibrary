using System;
using System.ComponentModel.DataAnnotations;

namespace HotelLibrary
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public int SingleBed { get; set; }
        public int DoubleBed { get; set; }


        public Room()
        {

        }
        public Room(int roomNumber, RoomStatus roomStatus, int singleBed, int doubleBed)
        {
            this.RoomNumber = roomNumber;
            this.SingleBed = singleBed;
            this.DoubleBed = doubleBed;
            this.RoomStatus = roomStatus;
        }

        public void SetStatus(RoomStatus status)
        {
            this.RoomStatus = status;
        }
    }
}