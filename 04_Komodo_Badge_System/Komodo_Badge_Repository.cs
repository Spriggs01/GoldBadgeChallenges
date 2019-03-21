using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Badge_System
{
    public class Komodo_Badge_Repository
    {
        List<string> doors = new List<string>();
        private Dictionary<int, List<String>> dictionary = new Dictionary<int, List<String>>();

        public void AddBadgeToList(Komodo_Badge_04 badge_04)
        {
            dictionary.Add(badge_04.BadgeID, badge_04.DoorName);

        }
        public Dictionary<int, List<String>> GetKeyValuePairs()
        {
            return dictionary;
        }

    }   
}
