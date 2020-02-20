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
                        PrintAllBookings();
                        Console.Write("Enter Booking ID: ");
                        var bookingID = Convert.ToInt32(Console.ReadLine());
                        var Booking = Airline.GetAllDetailsByBookingID(bookingID);
                        Console.WriteLine($"BookingID: {Booking.BookingID}, PassengerName: {Booking.PassengerName}, JourneyDate: {Booking.JourneyDate}, DepartingFrom: {Booking.DepartingAirport}, ArrivingAt: {Booking.ArrivalAirport}, FlightNumber: {Booking.FlightNumber}, Meal: {Booking.MealPreference}, EmailAddress: {Booking.EmailAddress}");
                        Console.Write("Enter New Journey Date: ");
                        var newDate = Convert.ToDateTime(Console.ReadLine());
                        Airline.UpdateReservation(bookingID,newDate);
                        break;

                    case "3":
                        //Still trying to figure out how to do cancel reservation. It will be easy to do once database integration is complete.
                        break;

                    case "4":
                        PrintAllBookings();
                        break;

                    case "5":
                        //Will add this once database integration is done.
                        break;
                        
                    default:
                        Console.WriteLine("Invalid Option. Please try again");
                        break;

                }

            }
        }

        private static void PrintAllBookings()
        {
            Console.Write("Enter EmailAddress: ");
            var emailAddress = Console.ReadLine();
            var bookings = Airline.GetAllBookingsByEmailAddress(emailAddress);
            foreach (var booking in bookings)
            {
                Console.WriteLine($"BookingID: {booking.BookingID}, PassengerName: {booking.PassengerName}, JourneyDate: {booking.JourneyDate}, DepartingFrom: {booking.DepartingAirport}, ArrivingAt: {booking.ArrivalAirport}, FlightNumber: {booking.FlightNumber}, Meal: {booking.MealPreference}, EmailAddress: {booking.EmailAddress}");
            }
        }
    }
}
