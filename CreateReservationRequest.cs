using System;

namespace HotelLibrary
{
    /** serialized and processed at POST /reservations/{customerId}
     *  Should enter API as:
     *  
     *  {
     *      doubleBeds: X,
     *      singleBeds: X,
     *      startDate:  XX-XX-XX,
     *      endDate:    XX-XX-XX,
     *  }
     */
    public class CreateReservationRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DoubleBeds { get; set; }
        public int SingleBeds { get; set; }

        public CreateReservationRequest()
        {
        }
    }
}
