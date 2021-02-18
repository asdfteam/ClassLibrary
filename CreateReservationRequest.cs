using System;

namespace HotelLibrary
{
    /** Processed at POST /reservations
     *  Should enter API as:
     *  
     *  {
     *      roomNumber: X,
     *      startDate:  XX-XX-XX,
     *      endDate:    XX-XX-XX,
     *  }
     */
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
