using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_5.Entities;
using Module_6_Task_5.UI;

namespace Module_6_Task_5.MenuElements
{
    public class CompleteTrain : ElementMenu
    {
        public CompleteTrain()
        {
            Active = false;
            Title = "Complete train";
            Description = "Add carriage to Train";
        }

        private void _completeTrain(ref Storage storage)
        {
            storage.Flight.CreateTrain();
            string[] carriagesOptions = new string[]
                {
                    "5 Seats",
                    "7 Seats",
                    "10 Seats",
                    "20 Seats"
                };

            while (!storage.Flight.CheckTrainIsComplete())
            {
                Console.Clear();
                int choosed = InOut.Select($"Choose Carriage to Add(Seats {storage.Flight.NumberOfTicketsPurchased}/{storage.Flight.Train.GetSeatsNumber()}):", carriagesOptions);

                switch (choosed)
                {
                    case 0:
                        storage.Flight.Train.AddCarriage(new Сarriage(5));
                        break;
                    case 1:
                        storage.Flight.Train.AddCarriage(new Сarriage(7));
                        break;
                    case 2:
                        storage.Flight.Train.AddCarriage(new Сarriage(10));
                        break;
                    case 3:
                        storage.Flight.Train.AddCarriage(new Сarriage(20));
                        break;
                }

            }
            Console.WriteLine($"Train complete! Seats {storage.Flight.NumberOfTicketsPurchased}/{storage.Flight.Train.GetSeatsNumber()}");
        }

        public override void Do(ref Storage storage, Menu menu)
        {

            _completeTrain(ref storage);
            base.Do(ref storage, menu);

        }
    }
}
