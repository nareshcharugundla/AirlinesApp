using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AirlinesApp
{
    /// <summary>
    /// This Airline class is the Factory class which contains methods for all the operations(Reservation, Manage Booking, Cancellation). This will call\instantiate the actual sub-classes.
    /// </summary>
    public static class Airline
    {
        //public static List<Booking> Bookings = new List<Booking>();
        private static AirlineContext db = new AirlineContext();
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
            string arrivalAirport, DateTime journeyDate, string emailAddress, Meal food = Meal.Vegetarian)
        {
            var f = new Flight();
            var Booking = new Booking
            {
                PassengerName = passengerName,
                DepartingAirport = departingAirport,
                ArrivalAirport = arrivalAirport,
                JourneyDate = journeyDate,
                MealPreference = food,
                EmailAddress = emailAddress
            };
            
            Booking.FlightNumber = f.GetFlightNumber(Booking.DepartingAirport, Booking.ArrivalAirport); ;

            db.Bookings.Add(Booking);
            db.SaveChanges();
            return Booking;
        }

        public static void UpdateReservation(int bookingID, DateTime newjourneyDate)
        {
            var booking = db.Bookings.SingleOrDefault(b => b.BookingID == bookingID);
            if(booking == null)
            {
                throw new ArgumentNullException("Invalid Booking ID. Please try again with a valid One!");
            }
            booking.UpdateBooking(newjourneyDate);
            db.SaveChanges();
        }

        public static IEnumerable<Booking> GetAllBookingsByEmailAddress(string emailAddress)
        {
            return db.Bookings.Where(b => b.EmailAddress == emailAddress).OrderByDescending(b => b.CreatedDate);
        }

        public static Booking GetAllDetailsByBookingID(int bookingID)
        {
            return db.Bookings.SingleOrDefault(b => b.BookingID == bookingID);
        }
    }
}
