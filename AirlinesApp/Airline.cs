﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    /// <summary>
    /// This Airline class is the Factory class which contains methods for all the operations(Reservation, Manage Booking, Cancellation). This will call\instantiate the actual sub-classes.
    /// </summary>
    class Airline
    {
        /// <summary>
        /// This method is for creating a Reservation based on the inputs parameters provided by user\user interface. It returns Booking type.
        /// </summary>
        /// <param name="passengerName">Name of the passenger</param>
        /// <param name="departingAirport">Passerger departing Airport</param>
        /// <param name="arrivalAirport">Passenger Arrival Airport</param>
        /// <param name="journeyDate">Travel Date</param>
        /// <param name="food">Mean preference</param>
        /// <returns></returns>
        public static Booking CreateReservation(string passengerName, string departingAirport, 
            string arrivalAirport, DateTime journeyDate, Meal food = Meal.Vegetarian)
        {
            var f = new Flight();
            var Booking = new Booking
            {
                PassengerName = passengerName,
                DepartingAirport = departingAirport,
                ArrivalAirport = arrivalAirport,
                JourneyDate = journeyDate,
                MealPreference = food
            };
            f.GetFlightNumber(Booking.DepartingAirport, Booking.ArrivalAirport);
            Booking.FlightNumber = f.FlightDetails;
            
            return Booking;
        }
    }
}