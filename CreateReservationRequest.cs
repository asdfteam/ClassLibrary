using System;

namespace HotelLibrary
{
    class CreateReservationRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomNumber { get; set; }

        public CreateReservationRequest(int RoomNum, DateTime start, DateTime end)
        {
            RoomNumber = RoomNum;
            StartDate = start;
            EndDate = end;
        }
    }
}
