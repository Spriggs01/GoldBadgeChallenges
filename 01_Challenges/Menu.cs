using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenges
{
  public  class Menu
    {
        
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public decimal OrderCost { get; set; }


        
        public Menu() { }
        public Menu (string mealName, string mealDescription, string ingredients, decimal orderCost, int mealNumber)
        {
            
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            OrderCost = orderCost;
            MealNumber = mealNumber;


        }
        

    }
}
