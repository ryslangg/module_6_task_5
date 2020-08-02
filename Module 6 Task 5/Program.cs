using Module_6_Task_5.MenuElements;
using Module_6_Task_5.Entities;
using Module_6_Task_5.UI;
using System;

namespace Module_6_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.Flight = new Flight();
            Menu menu = new Menu();
            
            menu.AddElement(new CreateFlightRoute());
            menu.AddElement(new SellTickets());
            menu.AddElement(new CompleteTrain());
            menu.AddElement(new RunFlight());            
            menu.AddElement(new Help());
            menu.AddElement(new Exit());

            while (menu.Active)
            {

                Console.Clear();
                InOut.BlockyPrint(new string[] 
                {
                    $"Flight: {storage.Flight.GetRouteInfo()}",
                    $"Tickets sold: {storage.Flight.NumberOfTicketsPurchased.ToString()}",
                    $"Carriage: {storage.Flight.GetCarraigeInfo()}",
                    $"State: {storage.Flight.GetState()}",
                });
                menu.Print();
                char keySymbol = Console.ReadKey(true).KeyChar;
                Console.Clear();
                menu.Run(keySymbol, ref storage);
            }
        }
    }
}
