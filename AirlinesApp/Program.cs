using System;

namespace AirlinesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to the Airlines!");
            while (true)
            {
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Make a new reservation");
                Console.WriteLine("2: Update reservation");
                Console.WriteLine("3: Cancel reservation");
                Console.WriteLine("4: Retrieve all reservations");
                Console.WriteLine("5: Check Availability");

                Console.WriteLine("Select an option to proceed further");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Airlines!");
                        return;
                    case "1":
                        Console.Write("Passenger Name: ");
                        var passengerName = Console.ReadLine();

                        Console.Write("Departing Airport: ");
                        var departingAirport = Console.ReadLine();

                        Console.Write("Arriving Airport: ");
                        var arrivingAirport = Console.ReadLine();

                        Console.Write("Journey Date(MM/DD/YYYY): ");
                        DateTime journeyDate = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Meal Preference: ");
                        var mealOptions = Enum.GetNames(typeof(Meal));

                        for (int i = 0; i < mealOptions.Length; i++)
                        {
                            Console.WriteLine($"{i}: {mealOptions[i]}");
                        }
                        var mealPreference = Enum.Parse<Meal>(Console.ReadLine());

                        Console.Write("Email Address: ");
                        var email = Console.ReadLine();

                        var myBooking = Airline.CreateReservation(passengerName, departingAirport, arrivingAirport, journeyDate, email, mealPreference);
                        Console.WriteLine($"BookingID: {myBooking.BookingID}, PassengerName: {myBooking.PassengerName}, JourneyDate: {myBooking.JourneyDate}, DepartingFrom: {myBooking.DepartingAirport}, ArrivingAt: {myBooking.ArrivalAirport}, FlightNumber: {myBooking.FlightNumber}, Meal: {myBooking.MealPreference}, EmailAddress: {myBooking.EmailAddress}");

                        break;
                    case "2":
                        
                    case "3":
                        
                    case "4":
                        
                    case "5":
                        
                    default:
                        Console.WriteLine("Invalid Option. Please try again");
                        break;

                }

            }



            
            

            //var myBooking2 = Airline.CreateReservation("Leela", "Seattle", "Bangalore", DateTime.UtcNow.AddDays(10), Meal.Vegetarian);
            //Console.WriteLine($"BookingID: {myBooking2.BookingID}, PassengerName: {myBooking2.PassengerName}, JourneyDate: {myBooking2.JourneyDate}, DepartingFrom: {myBooking2.DepartingAirport}, ArrivingAt: {myBooking2.ArrivalAirport}, FlightNumber: {myBooking2.FlightNumber}, Meal: {myBooking2.MealPreference}");
        }
    }
}
