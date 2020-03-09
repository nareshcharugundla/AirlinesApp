using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    public enum FlightEnum
    {
        AA123,
        BB456,
        CC789
    }

    /// <summary>
    /// This is the flight class. For now it has a method to determine the flight number based on properties Departing\Arriving Airport. 
    /// </summary>
    class Flight
    {
        /// <summary>
        /// Each property is for flight object. Since there is no database integration to store Total Capacity and Availability per flight not adding any logic to determine them
        /// </summary>
        #region Flight Class Properties
        public FlightEnum FlightNumber { get; set; }
        public string FlightStartAirport { get; set; }
        public string FlightDestinationAirport { get; set; }
        public int TotalCapacity { get; set; }
        public int Availability { get; set; }
        #endregion

        public void GetFlightNumber(string DepartingAirport, string ArrivalAirport)
        {
            if(DepartingAirport == "Seattle" && ArrivalAirport == "Hyderabad")
            {
                FlightNumber = FlightEnum.AA123;
            }
            else if(DepartingAirport == "Seattle" && ArrivalAirport == "Bangalore")
            {
                FlightNumber = FlightEnum.BB456;
            }
        }
    }
}
