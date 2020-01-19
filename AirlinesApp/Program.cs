using System;

namespace AirlinesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Airlines. Please select an option below");
            Console.WriteLine("1. Search Flights\n" +
                              "2. Manage Booking\n");
            int selection = int.Parse(Console.ReadLine());

        }
    }
}
