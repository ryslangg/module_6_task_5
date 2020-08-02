using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_6_Task_5.Entities
{
    public class Train
    {
        private List<Сarriage> _carriages = new List<Сarriage>();

        public int GetСarriageNumber()
        {
            return _carriages.Count;
        }

        public int GetSeatsNumber()
        {
            return _carriages.Sum( carriage => carriage.SeatsNumber );
        }

        public void AddCarriage(Сarriage carriage)
        {
            _carriages.Add(carriage);
        }
    }
}
