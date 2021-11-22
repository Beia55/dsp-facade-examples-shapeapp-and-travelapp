using System;

namespace TravelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TravelFacade travelFacade = new TravelFacade();

            travelFacade.CreatePerson("Filip", "Deia", 20, 1122334455, "Str. Roses, Nr. 10");
            travelFacade.CreateBookingInfo(700, "Oradea", "Viena", new DateTime(), new DateTime());
            travelFacade.BookFlight(true, 3, FlyTicketType.PrimaryClass);
            
            Console.WriteLine("\n");

            travelFacade.CreatePerson("Marc", "Timi", 22, 1144552233, "Str. Ibsen, Nr. 50");
            travelFacade.CreateBookingInfo(500, "Cluj", "Paris", new DateTime(), new DateTime());
            travelFacade.BookTrain(TrainTicketType.Student);
            
            Console.WriteLine("\n");

            travelFacade.CreatePerson("Cristin", "Georgi", 21, 1011122334, "Str. Iris, Nr. 33");
            travelFacade.CreateBookingInfo(600, "Londra", "Cluj", new DateTime(), new DateTime());
            travelFacade.BookHotel();

        }
    }
}
