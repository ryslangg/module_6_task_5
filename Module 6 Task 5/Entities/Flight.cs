using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_5.Entities
{
    public class Flight
    {
        public string DeparturePoint { get; private set; }
        public string Destination { get; private set; }
        public int NumberOfTicketsPurchased { get; private set; }
        public Train Train { get; private set; }

        public void CreateTrain()
        {
            Train = new Train();
        }

        public void SetRoute(string departurePoint, string destination) 
        {
            if (DeparturePoint == null && Destination == null)
            {
                DeparturePoint = departurePoint;
                Destination = destination;
            }            
        }

        public string GetRouteInfo()
        {
            if (DeparturePoint == null && Destination == null)
            {
                return "N/A";
            }
            return $"{DeparturePoint}-{Destination}";
        }

        public string GetState()
        {
            if (DeparturePoint == null && Destination == null)
            {
                return "Not created!";
            }

            if (NumberOfTicketsPurchased == 0)
            {
                return "Ready to sell tickets!";
            }

            if (Train == null)
            {
                return "Not complete!";
            }

            return "ready to go!";
        }

        public void SetNumberOfTickets(int number)
        {
            if( number>0 && NumberOfTicketsPurchased == 0)
            {
                NumberOfTicketsPurchased = number;
            }
        }

        public bool CheckTrainIsComplete()
        {
            if (Train == null)
            {
                return false;
            }
            return Train.GetSeatsNumber() >= NumberOfTicketsPurchased;
        }

        public string GetCarraigeInfo()
        {
            if(Train != null)
            {
                return $"{Train.GetСarriageNumber()}(Seats - {Train.GetSeatsNumber()})";
            }
            return "N/A";
        }
    }
}
