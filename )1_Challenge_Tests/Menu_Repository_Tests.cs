using System;
using _01_Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_Challenge_Tests
{
    [TestClass]
    public class Menu_Repository_Tests
    {
        private Menu_Repository _menuRepo = new Menu_Repository();

        [TestMethod]
        public void Menu_Repository_AddItemToMenu()
        {
            Menu menu = new Menu();
            _menuRepo.AddItemToMenu(menu);


            var actual = _menuRepo.GetMenus().Count;
            var expected = 1;
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Menu_Repository_RemoveProductBySpecifications()
        {
            Menu menu = new Menu();
            Menu _menu = new Menu();
            menu.MealNumber = 1;
            _menuRepo.AddItemToMenu(menu);
            _menuRepo.AddItemToMenu(_menu);
            _menuRepo.RemoveProductBySpecifications(1);

            

            var actual = _menuRepo.GetMenus().Count;
            var expected = 1;
            Assert.AreEqual(expected, actual);

        }
        
            
        }
    }

