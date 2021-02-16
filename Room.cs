namespace HotelLibrary
{
    public class Room
    {
        public int RoomNumber { get; }
        public RoomStatus Status { get; set; }
        public int SingleBed { get; set; }
        public int DoubleBed { get; set; }

        public Room(int roomNumber, int singleBed, int doubleBed)
        {
            this.RoomNumber = roomNumber;
            this.SingleBed = singleBed;
            this.DoubleBed = doubleBed;
            this.Status = RoomStatus.Available;
        }

        public void SetStatus(RoomStatus status)
        {
            this.Status = status;
        }
    }
}