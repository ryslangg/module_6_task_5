using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_5.Entities;
using Module_6_Task_5.UI;

namespace Module_6_Task_5.MenuElements
{
    public class RunFlight : ElementMenu
    {
        public RunFlight()
        {
            Active = false;
            Title = "Send flight!";
            Description = "Flight departure to destination!";
        }

        public override void Do(ref Storage storage, Menu menu)
        {
            
            InOut.Alert($"Flight {storage.Flight.GetRouteInfo()} set off!");
            storage.Flight = new Flight();
            Active = false;
            menu.Elements[0].Active = true;
        }
    }
}
