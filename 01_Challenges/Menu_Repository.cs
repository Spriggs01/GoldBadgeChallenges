using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenges
{
    public class Menu_Repository
    {
        private List<Menu> _menuList = new List<Menu>();

        public void AddItemToMenu(Menu menu)
        {
            _menuList.Add(menu);
        }
        public List<Menu> GetMenus()
        {
            return _menuList;
        }
        public bool RemoveProductBySpecifications(int mealId)
        {
            foreach (Menu menu in _menuList)
            {
                if (mealId == menu.MealNumber)
                {
                    _menuList.Remove(menu);
                    return true;
                }
            }return false;
            
        }
    

       
        
            
          
       
         
    }
}
