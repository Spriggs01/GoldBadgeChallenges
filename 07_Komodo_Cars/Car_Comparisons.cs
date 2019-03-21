using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Cars
{
    public enum FuelType
    {
         Gas, Hybrid, Electric
    }


    public   class Car_Comparisons
    {
      

        public FuelType TypeOfFuel { get; set; }
        public string CarType { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car_Comparisons() { }
        public Car_Comparisons(FuelType typeOfFuel, string carType, string color, int year)
        {
            TypeOfFuel = typeOfFuel;
            CarType = carType;
            Color = color;
            Year = year;
        }
    }
}
