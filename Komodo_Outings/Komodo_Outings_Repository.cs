using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Outings
{
  public  class Komodo_Outings_Repository
    {
        private List<Outings> _outingsList = new List<Outings>();

        public void AddOutingToList(Outings outings)
        {
            _outingsList.Add(outings);
        }
        public List<Outings> GetOutings()
        {
            return _outingsList;
;        }
        public decimal GetAllPeopleCount(Outings outing)
        {
            decimal totalCount = 0m;
            foreach (Outings person in _outingsList)
            {
                totalCount += person.PeopleAtEvent;
            }
            return totalCount;
        }
    }
}
