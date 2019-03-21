using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Cars
{
    public class ProgramUI_06
    {
        public static _06_Komodo_Cars_Repository _cars_Repository = new _06_Komodo_Cars_Repository();
        List<Car_Comparisons> gas = _cars_Repository.GetGasList();
        List<Car_Comparisons> elctric = _cars_Repository.GetElectricList();
        List<Car_Comparisons> hyrbid = _cars_Repository.GetHybridList();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add Car to list\n" +
                    "2. Remove Car from list\n" +
                    "3. Update Information\n" +
                    "4. See all.");

                string OrderAsString = Console.ReadLine();
                int mainMenu = int.Parse(OrderAsString);
                switch (mainMenu)
                {
                    case 1:
                        AddCarToList();
                        break;
                    case 2:
                        RemoveCarFromList();
                        break;
                    case 3:
                        UpdateInformation();
                        break;
                    case 4:
                        SeeAll();
                        break;


                }


            }
        }

        private void AddCarToList()
        {
            Car_Comparisons car = new Car_Comparisons();
            Console.WriteLine("What type of car is it?\n" +
                "1. Gas\n" +
                "2. Electrc\n" +
                "3. Hybrid");

            string InputAsString = Console.ReadLine();
            int carType = int.Parse(InputAsString);



            switch (carType)
            {
                case 1:
                    car.TypeOfFuel = FuelType.Gas;
                    break;
                case 2:
                    car.TypeOfFuel = FuelType.Electric;
                    break;
                case 3:
                    car.TypeOfFuel = FuelType.Hybrid;
                    break;


            }

            Console.WriteLine("What model is the car?");
            string model = Console.ReadLine();

            Console.WriteLine("What Year is the car?");
            string yearOfCar=  Console.ReadLine();

            Console.WriteLine("What Color is the car?");
            string colorOfCar =  Console.ReadLine();

            if (car.TypeOfFuel == FuelType.Gas)
            {
                _cars_Repository.AddCarToList(car, gas);

            }

            if (car.TypeOfFuel == FuelType.Hybrid)
            {
                _cars_Repository.AddCarToList(car, hyrbid);
            }
            if (car.TypeOfFuel == FuelType.Electric)
            {
                _cars_Repository.AddCarToList(car, elctric);
            }
        }

        private void SeeAll()
        {
            throw new NotImplementedException();
        }

        private void UpdateInformation()
        {
            throw new NotImplementedException();
        }

        private void RemoveCarFromList()
        {
            FuelType fuelTypeToRemove;
            List<Car_Comparisons> list;
            Car_Comparisons car = new Car_Comparisons();
            Console.WriteLine("What car would you like to Remove?\n" +
                "1. Gas\n" +
                "2. Electric\n" +
                "3. Hybrid.");

            string asString = Console.ReadLine();
            int removeCar = int.Parse(asString);

            switch (removeCar)
            {
                case 1:
                    fuelTypeToRemove = FuelType.Gas;
                   // list = _cars_Repository.GetGasList();
                    break;
                case 2:
                    fuelTypeToRemove = FuelType.Electric;
                    break;
                case 3:
                    fuelTypeToRemove = FuelType.Hybrid;
                    break;
            }
        }
        
    }


}


