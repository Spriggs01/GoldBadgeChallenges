using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Badge_System
{
    public class Komodo_Badge_04
    {
        public int BadgeID { get; set; }
        public List<String> DoorName { get; set; }

        public Komodo_Badge_04() { }
        public Komodo_Badge_04(int badgeID, List<String> doorName)
        {
            BadgeID = badgeID;
            DoorName = doorName;

        }
       




    }
}
