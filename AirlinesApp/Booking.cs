using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    class Booking
    {
        public string BookingID { get; set; }
        public int FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public string DepartingAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime JourneyDate { get; set; }
    }
}
