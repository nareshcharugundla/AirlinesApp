using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    public enum FlightEnum
    {
        AA123 = 100,
        BB456,
        CC789
    }
    class Flight
    {
        private static int LastKnownAvailability = 100;
        #region Flight Class Properties
        public FlightEnum FlightDetails { get; private set; }
        public string FlightStartAirport { get; set; }
        public string FlightDestinationAirport { get; set; }
        public int TotalCapacity { get; set; }
        public int Availability { get; private set; }
        #endregion

        public void GetFlightNumber(string DepartingAirport, string ArrivalAirport)
        {
            if(DepartingAirport == "Seattle" && ArrivalAirport == "Hyderabad")
            {
                FlightDetails = FlightEnum.AA123;
            }
            else if(DepartingAirport == "Seattle" && ArrivalAirport == "Bengalore")
            {
                FlightDetails = FlightEnum.BB456;
            }
        }
    }
}
