using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    class ReservationResponse
    {
        public Room Room { get; set; }
        public Customer Customer { get; set; }

        public ReservationResponse(Room Room, Customer Customer)
        {

        }
    }
}
