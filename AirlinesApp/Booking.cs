using System;
using System.Collections.Generic;
using System.Text;

namespace AirlinesApp
{
    public enum Meal
    {
        Vegetarian,
        NonVeg,
        KidSize
    }
    class Booking
    {
        private static int LastBookingNumber = 0;
        public int BookingID { get; private set; }
        public FlightEnum FlightNumber { get; internal set; }
        public string PassengerName { get; set; }
        public string DepartingAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime JourneyDate { get; set; }
        public Meal MealPreference { get; set; }

        public Booking()
        {
            BookingID = ++LastBookingNumber;
            CreatedDate = DateTime.UtcNow;
        }
    }
}
