using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AirlinesApp
{
    /// <summary>
    /// This is the flight class. For now it has a method to determine the flight number based on properties Departing\Arriving Airport. 
    /// </summary>
    class Flight
    {
        public static AirlineContext db = new AirlineContext();
        /// <summary>
        /// Each property is for flight object. Since there is no database integration to store Total Capacity and Availability per flight not adding any logic to determine them
        /// </summary>
        #region Flight Class Properties
        public int FlightNumber { get; set; }
        public string FlightStartAirport { get; set; }
        public string FlightDestinationAirport { get; set; }
        public int TotalCapacity { get; set; }
        public int Availability { get; set; }
        #endregion

        public int GetFlightNumber(string DepartingAirport, string ArrivalAirport)
        {
            var Flight = db.Flights.SingleOrDefault(f => f.FlightStartAirport == DepartingAirport && f.FlightDestinationAirport == ArrivalAirport);
            return Flight.FlightNumber;
        }
    }
}
