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
        
        public int BookingID { get; set; }
        public int FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public string DepartingAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime JourneyDate { get; set; }
        public Meal MealPreference { get; set; }
        public string EmailAddress { get; set; }
        public Flight Flight { get; set; }

        public Booking()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public void UpdateBooking(DateTime newjourneyDate)
        {
            JourneyDate = newjourneyDate;
        }
    }
}
