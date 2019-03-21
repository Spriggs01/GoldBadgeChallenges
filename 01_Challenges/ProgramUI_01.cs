using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenges
{
    public class ProgramUI_01
    {
        private Menu_Repository _repository = new Menu_Repository();

        private Menu _menuList = new Menu();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello, What do you want to do\n" +
                                   "1. Add a menu item\n" +
                                   "2. Remove a menu item\n" +
                                   "3. See the menu item description\n" +
                                   "4.Exit");

                int inputType = int.Parse(Console.ReadLine());
                switch (inputType)
                {
                    case 1:
                        AddNewMenuItem();
                        break;
                    case 2:
                        RemoveMenuItem();
                        break;
                    case 3:
                        SeeItemDescription();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void RemoveMenuItem()
        {
            Console.WriteLine("What would you like to remove?");
            int idOne =int.Parse(Console.ReadLine());

            _repository.RemoveProductBySpecifications(idOne);
        }

        private void AddNewMenuItem()
        {

            Console.WriteLine("Please add meal number");
            string AddAsString = Console.ReadLine();
            int id = int.Parse(AddAsString);
            

            Console.WriteLine("What would you like to add?");
            string itemName = Console.ReadLine();
            Console.WriteLine("Please enter the item description");
            string itemDescription = Console.ReadLine();
            Console.WriteLine("Please add Ingredients");
            string itemIngredients = Console.ReadLine();

            Console.WriteLine("Please enter the cost of your item.");
            decimal TotalCost = decimal.Parse(Console.ReadLine());

            Menu menu = new Menu(itemName, itemDescription, itemIngredients, TotalCost, id);

            _repository.AddItemToMenu(menu);




        }

        private void SeeItemDescription()
        {



            List<Menu> list = _repository.GetMenus();
            foreach (Menu menu in list)
            {
                Console.WriteLine($"{menu.MealNumber}\n" +
                    $"{menu.MealName}\n" +
                    $"{menu.MealDescription}\n" +
                    $"{menu.Ingredients}\n" +
                    $"{menu.OrderCost}");
            }
            Console.ReadLine();

        }



    }


}
