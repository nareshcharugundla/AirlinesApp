using System;

namespace AirlinesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooking = new Booking();
            myBooking.PassengerName = "Naresh";
            myBooking.DepartingAirport = "Seattle";
            myBooking.ArrivalAirport = "Hyderabad";
            myBooking.JourneyDate = DateTime.UtcNow.AddDays(10); //for now just adding 10 days for current time as journey date
            myBooking.MealPreference = Meal.Vegetarian;
            
        }
    }
}
