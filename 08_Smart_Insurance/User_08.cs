using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Smart_Insurance
{
    public enum GenderType
    {
        Male =1, Female, Other

    }
  public  class User_08
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public decimal TotalCost { get; set; }

        public User_08() { }
        public User_08(string name, int age, GenderType gender, decimal totalCost)
        {
            Name = name;
            Age = age;
            Gender = gender;
            TotalCost = totalCost;
        }
    }
}
