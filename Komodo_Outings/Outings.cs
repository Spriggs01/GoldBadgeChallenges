using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Outings
{
    public class Outings
    {
        public enum EventType
        {
            None, Golf, Bowling, AmusementPark, Concert
        }


        public DateTime DateOfEvent { get; set; }
        public int PeopleAtEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostOfEvent { get; set; }
        public EventType TypeOfEvent { get; set; }


        public Outings() { }
        public Outings(EventType typeOfEvent, DateTime dateOfEvent, int peopleAtEvent, decimal costPerPerson)
        {
            TypeOfEvent = typeOfEvent;
            DateOfEvent = dateOfEvent;
            PeopleAtEvent = peopleAtEvent;
            CostPerPerson = costPerPerson;
            CostOfEvent = peopleAtEvent * costPerPerson;
        }




    }

}
