using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_5.Entities
{
    public class Сarriage
    {
        public int SeatsNumber { get; private set; }

        public Сarriage(int seatsNumber)
        {
            SeatsNumber = seatsNumber;
        }
    }
}
