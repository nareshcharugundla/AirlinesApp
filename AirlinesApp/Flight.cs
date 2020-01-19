using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    class Flight
    {
        #region Flight Class Properties
        public int FlightNumber { get; set; }
        public string FlightStartAirport { get; set; }
        public string FlightDestinationAirport { get; set; }
        public int TotalCapacity { get; set; }
        public int Availability { get; private set; }
        #endregion
    }
}
