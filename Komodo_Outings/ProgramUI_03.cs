
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Komodo_Outings.Outings;

namespace Komodo_Outings
{
    public class ProgramUI_03
    {
        private Komodo_Outings_Repository _outings_Repository = new Komodo_Outings_Repository();
        private Outings outings = new Outings();


        public void Run()
        {
            _outings_Repository.AddOutingToList(new Outings(EventType.Golf, DateTime.Now, 200, 10));
            _outings_Repository.AddOutingToList(new Outings(EventType.Golf, DateTime.Now, 100, 15));
            _outings_Repository.AddOutingToList(new Outings(EventType.Bowling, DateTime.Now, 200, 7));
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?:\n" +
                    "1. See a list of the Outings\n" +
                    "2. Add an outing to the list\n" +
                    "3. See the combined cost for all the current outings.\n" +
                    "4. See the cost of each type of outing.");
                string OrderAsString = Console.ReadLine();
                int Menu = int.Parse(OrderAsString);

                switch (Menu)
                {
                    case 1:
                        SeeAllist();
                        break;
                    case 2:
                        AddAnOuting();
                        break;
                    case 3:
                        SeeCombinedCost();
                        break;
                    case 4:
                        SeeCostOfEachType();
                        break;

                }
            }
        }

        private void SeeCostOfEachType()
        {
            List<Outings> outingsList = _outings_Repository.GetOutings();
            decimal golfCost = 0;
            decimal amusementParkCost = 0;
            decimal concertCost = 0;
            decimal bowlingCost = 0;
            foreach (Outings outings in outingsList)
            {
                switch (outings.TypeOfEvent)
                {
                    case EventType.Golf:
                        golfCost += outings.CostOfEvent;
                        break;
                    case EventType.AmusementPark:
                        amusementParkCost += outings.CostOfEvent;
                        break;
                    case EventType.Concert:
                        concertCost += outings.CostOfEvent;
                        break;
                    case EventType.Bowling:
                        bowlingCost += outings.CostOfEvent;
                        break;
                }

            }
            Console.WriteLine("The cost of all Golf Outings is {0:C}", golfCost);
            Console.WriteLine("The cost of all Amusement Park Outings is {0:C}", amusementParkCost);
            Console.WriteLine("The cost of all Concert Outings is {0:C}", concertCost);
            Console.WriteLine("The cost of all Bowling Outings is {0:C}", bowlingCost);
            Console.ReadLine();



        }

        private void SeeCombinedCost()
        {
            List<Outings> outingsList = _outings_Repository.GetOutings();
            decimal combinedCost = 0m;
            foreach (Outings outings in outingsList)
            {
                combinedCost += outings.CostOfEvent;
            }
            Console.WriteLine("The combined cost of all the outings is {0:C}", combinedCost);
            Console.ReadLine();

        }

        private void SeeAllist()
        {
            List<Outings> outingsList = _outings_Repository.GetOutings();
            Console.WriteLine("{0:-10} {1:10} {2:-20} {3:-20} {4:-10}", "Event Cost", "Cost per Person", "Event Date", "Event Type", "Head Count");
            foreach (Outings outings in outingsList)
            {
                Console.WriteLine($"{outings.CostOfEvent:C} \t {outings.CostPerPerson:C} {outings.DateOfEvent.ToShortDateString(),+20} {outings.TypeOfEvent,+20} {outings.PeopleAtEvent,+10}");
            }
            Console.ReadLine();


        }

        private void AddAnOuting()

        {
            Console.WriteLine("What Type of Event are you wanting to input information for?:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n" +
                "5. See All Data.");

            string inputAsString = Console.ReadLine();
            int inputType = int.Parse(inputAsString);
            EventType eventType = EventType.None;

            switch (inputType)
            {
                case 1:
                    eventType = EventType.Golf;
                    break;
                case 2:
                    eventType = EventType.Bowling;
                    break;
                case 3:
                    eventType = EventType.AmusementPark;
                    break;
                case 4:
                    eventType = EventType.Concert;
                    break;

            }


            Console.WriteLine("What Date was the Event?\n" +
           "month/date/year.");
            string dateofConcert = Console.ReadLine();
            DateTime dateOfEvent = DateTime.Parse(dateofConcert);


            Console.WriteLine("How many people attended the Event?");
            string concert = Console.ReadLine();
            int peopleAtEvent = int.Parse(concert);

            Console.WriteLine("How much did each person pay?");
            string costForPerson = Console.ReadLine();
            decimal costPerPerson = decimal.Parse(costForPerson);




            Outings outing = new Outings(eventType, dateOfEvent, peopleAtEvent, costPerPerson);
            _outings_Repository.AddOutingToList(outing);


        }

    }
}










