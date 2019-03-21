using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public class ProgramUI_02
    {
        private Claims_Repository _claimRepo = new Claims_Repository();
        private Claims _claim = new Claims();
        public void Run()
        {
            _claimRepo.AddClaimtoQueue(new Claims(1, "Car Accident on 465.", 400, DateTime.Now, DateTime.Now, true, ClaimType.Car));

            _claimRepo.AddClaimtoQueue(new Claims(2, "House Break In.", 400, DateTime.Now, DateTime.Now, true, ClaimType.Home));


            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?:\n" +
                    "1.See all Claims\n" +
                    "2.Take care of next Claim\n" +
                    "3. Enter a new Claim.");
                string InputAsString = Console.ReadLine();
                int inputType = int.Parse(InputAsString);
                switch (inputType)
                {
                    case 1:
                        SeeAllClaims();
                        break;
                    case 2:
                        TakeCareOfNextClaim();
                        break;
                    case 3:
                        EnterANewClaim();
                        break;

                }
            }
        }

        private void EnterANewClaim()
        {
            Claims newClaim = new Claims();
            Console.WriteLine("Enter the Claim information:\n" +
                "What is the Claim ID?");
            string claimId = Console.ReadLine();

            newClaim.ClaimId = int.Parse(claimId);

            Console.WriteLine("What is the Claim Description?\n" +
                "For Example: Car Accident on 465N");
            Console.ReadLine();

            Console.WriteLine("What is the Claim Amount?");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = decimal.Parse(claimAmount);

            Console.WriteLine("What is the Claim Type?:\n" +
                "1. Car\n" +
                "2. Home \n" +
                "3. Theft\n");
            string OrderAsString = Console.ReadLine();

            int claimType = int.Parse(OrderAsString);

            switch (claimType)
            {
                case 1:
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case 2:
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case 3:
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;

            }

            Console.WriteLine("When did the incident occur?\n" +
                "month/date/year.");
            string DateofIncident = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(DateofIncident);

            Console.WriteLine("When was the claim entered?\n" +
                "month/date/year.");
            string DateofClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(DateofClaim);


            double DayDifference = (newClaim.DateOfClaim - newClaim.DateOfIncident).TotalDays;
            if (DayDifference > 30)
            {
                newClaim.IsValid = false;
            }
            else
            {
                newClaim.IsValid = true;

            }

            _claimRepo.AddClaimtoQueue(newClaim);
        }
        private void TakeCareOfNextClaim()
        {
            Claims NextClaim = _claimRepo.GetClaims().Peek();

            Console.WriteLine("Here are the details for the next claim to be handled.");
            Console.WriteLine("Claim ID: {0}", NextClaim.ClaimId);
            Console.WriteLine("Type: {0}", NextClaim.TypeOfClaim);
            Console.WriteLine("Description: {0}", NextClaim.ClaimDescription);
            Console.WriteLine("Amount: {0:C}", NextClaim.ClaimAmount);
            Console.WriteLine("Date of Accident: {0:MM/dd/yy}", NextClaim.DateOfIncident);
            Console.WriteLine("Date of Claim: {0:MM/dd/yy}", NextClaim.DateOfClaim);
            Console.WriteLine("Is it Valid?: {0}", NextClaim.IsValid);

            Console.WriteLine("Do you want to deal with this claim now\n" +
                "Y OR\n" +
                "N.");

            string TakeNextClaim = Console.ReadLine();
            if (TakeNextClaim.ToUpper() == "Y")
            {
                _claimRepo.GetNextClaim();
            }
        }

        private void SeeAllClaims()
        {
            IEnumerable<Claims> claimsData = _claimRepo.GetClaims().AsEnumerable<Claims>();
            //ClaimID   Type    Description             Amount      DateOfAccident  DateOfClaim      IsValid
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-5} {4,-5} {5,-5} {6,-10}", "Claim ID", "Type", "Description", "Amount", "DateOfAccident", "DateOFClaim", "IsValid");
            foreach (Claims claim in claimsData)
            {
                Console.WriteLine("{0,-5} {1,-8} {2,-15} {3,-5}  {4,-5} {5,-5} {6,-5}", claim.ClaimId, claim.TypeOfClaim, claim.ClaimDescription, claim.ClaimAmount, claim.DateOfIncident, claim.DateOfClaim, claim.IsValid); ;
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }


    }
}
