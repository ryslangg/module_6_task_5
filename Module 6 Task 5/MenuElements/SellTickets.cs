using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_5.Entities;
using Module_6_Task_5.UI;

namespace Module_6_Task_5.MenuElements
{
    public class SellTickets : ElementMenu
    {
        public SellTickets()
        {
            Active = false;
            Title = "Sell ticket";
            Description = "Sells tickets automatically";
        }

        public override void Do(ref Storage storage, Menu menu)
        {
            Random rand = new Random();
            storage.Flight.SetNumberOfTickets(rand.Next(1, 100));
            InOut.Alert($"Tickets sold - {storage.Flight.NumberOfTicketsPurchased}!");
            base.Do(ref storage, menu);
        }
    }
}
