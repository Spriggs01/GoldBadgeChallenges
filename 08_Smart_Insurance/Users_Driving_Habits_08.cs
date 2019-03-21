using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Smart_Insurance
{
    public class Users_Driving_Habits_08
    {
        public int Speed { get; set; }
        public int Swerve { get; set; }
        public int RollThroughStop { get; set; }
        public int FollowTooClose { get; set; }

        public Users_Driving_Habits_08() { }
        public Users_Driving_Habits_08(int speed, int swerve, int rollThroughStop, int followTooClose)
        {
            Speed = speed;
            Swerve = swerve;
            RollThroughStop = rollThroughStop;
            FollowTooClose = followTooClose;
        }
    }
}
