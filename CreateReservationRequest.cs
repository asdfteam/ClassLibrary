using System;

namespace HotelLibrary
{
    /** Processed at POST /reservations/{customerId}
     *  Should enter API as:
     *  
     *  {
     *      roomNumber: X,
     *      startDate:  XX-XX-XX,
     *      endDate:    XX-XX-XX,
     *  }
     */
    public class CreateReservationRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomNumber { get; set; }

        public CreateReservationRequest()
        {
        }
    }
}
