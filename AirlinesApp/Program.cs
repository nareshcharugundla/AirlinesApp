using System;

namespace AirlinesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooking = Airline.CreateReservation("Naresh", "Seattle", "Hyderabad", DateTime.UtcNow.AddDays(10),Meal.NonVeg);
            Console.WriteLine($"BookingID: {myBooking.BookingID}, PassengerName: {myBooking.PassengerName}, JourneyDate: {myBooking.JourneyDate}, DepartingFrom: {myBooking.DepartingAirport}, ArrivingAt: {myBooking.ArrivalAirport}, FlightNumber: {myBooking.FlightNumber}, Meal: {myBooking.MealPreference}");

            var myBooking2 = Airline.CreateReservation("Leela", "Seattle", "Bangalore", DateTime.UtcNow.AddDays(10), Meal.Vegetarian);
            Console.WriteLine($"BookingID: {myBooking2.BookingID}, PassengerName: {myBooking2.PassengerName}, JourneyDate: {myBooking2.JourneyDate}, DepartingFrom: {myBooking2.DepartingAirport}, ArrivingAt: {myBooking2.ArrivalAirport}, FlightNumber: {myBooking2.FlightNumber}, Meal: {myBooking2.MealPreference}");
        }
    }
}
