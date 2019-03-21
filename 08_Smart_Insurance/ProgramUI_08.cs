using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Smart_Insurance
{
    public class ProgramUI_08
    {
        public Smart_Insurance_Repository_08 _insuranceRepo = new Smart_Insurance_Repository_08();
        private User_08 _user = new User_08();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello, what would you like to do?\n" +
                    "1.Register User\n" +
                    "2. Input User Habits\n" +
                    "3.View Information\n" +
                    "4. Exit The Application.");

                string orderAsString = Console.ReadLine();
                int mainMenu = int.Parse(orderAsString);
                switch (mainMenu)
                {
                    case 1:
                        RegisterUser();
                        break;
                    case 2:
                        InputUserHabits();
                        break;
                    case 3:
                        ViewInformation();
                        break;

                    case 5:
                        running = false;
                        break;
                }
            }
        }



        public void RegisterUser()
        {
            Console.WriteLine("Enter the Users Full Name:");
            _user.Name = Console.ReadLine();

            Console.WriteLine("Enter User's Age.");
            _user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the User's Gender?\n" +
                "1. Male\n" +
                "2. Female\n" +
                "3. Other");
            string genderAsString = Console.ReadLine().ToLower();
            switch (genderAsString)
            {
                case "male":
                case "1":
                    _user.Gender = GenderType.Male;
                    break;
                case "female":
                case "2":
                    _user.Gender = GenderType.Female;
                    break;
                default:
                    _user.Gender = GenderType.Other;
                    break;
            }
        }

        private void InputUserHabits()
        {
            Console.WriteLine("How often does the User Speed?");
            string speed = Console.ReadLine();
            int speedString = int.Parse(speed);

            decimal speedViolations = 0m;
            if (speedString > 55)
                speedViolations = 35m;

            Console.WriteLine("How often does the User Swerve?");
            string swerve = Console.ReadLine();
            int swervestring = int.Parse(swerve);

            decimal swerveViolations = 0m;
            if (swervestring > 10)
                swerveViolations = 40m;

            Console.WriteLine("How often does the User Roll Through A Stop Sign?");
            string rollThrough = Console.ReadLine();
            int rollThroughString = int.Parse(rollThrough);

            decimal rollThroughViolations = 0m;

            if (rollThroughString > 10)
                rollThroughViolations = 45m;

            Console.WriteLine("How often does the User Follow Too Close?");
            string followTooClose = Console.ReadLine();
            int followTooCloseString = int.Parse(followTooClose);

            decimal followTooCloseViolations = 0m;
            if (followTooCloseString > 15)
                followTooCloseViolations = 50m;


            decimal totalCost = speedViolations + swerveViolations + rollThroughViolations + followTooCloseViolations;
            _user.TotalCost = totalCost;
            Console.WriteLine("Here is the {_user.Name} Premium Cost");

            _insuranceRepo.AddUserToList(_user);
        }
        

        public void ViewInformation()
        {
            Console.WriteLine($"Here is the information for {_user.Name}");

            List<User_08> users = _insuranceRepo.GetUsersList();
            foreach (User_08 user in users)
            {
                Console.WriteLine($"Here is the users information: {user.Name} {user.Age} {user.Gender}");
                Console.WriteLine($"Here is the Users cost {user.TotalCost} ");
            }
            Console.ReadLine();







        }


    }
}
