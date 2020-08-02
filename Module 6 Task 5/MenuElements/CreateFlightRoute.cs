using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_5.Entities;
using Module_6_Task_5.UI;

namespace Module_6_Task_5.MenuElements
{
    public class CreateFlightRoute : ElementMenu
    {
        public CreateFlightRoute()
        {
            Title = "Create Flight";
            Description = "Create new fligh";
        }

        public override void Do(ref Storage storage, Menu menu)
        {
                string start = InOut.Dialog("Enter the starting point:");
                string end = InOut.Dialog("Enter the destenation point:");
                storage.Flight.SetRoute(start, end);
                InOut.Alert("Route created!");
                base.Do(ref storage, menu);
        }
    }
}
