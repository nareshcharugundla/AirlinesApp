using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    class Reservation
    {
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
            };
            f.GetFlightNumber(Booking.DepartingAirport, Booking.ArrivalAirport);
            Booking.FlightNumber = f.FlightDetails;

            return Booking;
        }
    }
}
