using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApps
{
    class MenuRepoPattern
    {
        
        protected readonly List<Menu> _menuDirectory = new List<Menu>();
        // Create
        public bool AddMenuContent(Menu items)
        {
            int startcount = _menuDirectory.Count;
            _menuDirectory.Add(items);
            return _menuDirectory.Count > startcount;
        }
        //read
        public List<Menu> GetItems()
        {
            return _menuDirectory;
        }
        public List<Menu> GetItemsByNumber(int mealNumber)
        {
            List<Menu> mealNumbers = new List<Menu>();
            foreach(Menu item in _menuDirectory)
            {
                if(item.MealNumber == mealNumber)
                {
                    return mealNumbers;
                }
                
            }
            return null;
        }

        //update
        
        public bool UpdateExistingMenuItemNumbers(int originalItemNumber, Menu newmenudata)
        {
            
            List<Menu> oldMenuList = GetItemsByNumber(originalItemNumber);

            foreach (Menu item in oldMenuList)
            {


                if (item != null)
                {
                    item.MealNumber = newmenudata.MealNumber;
                    item.MealName = newmenudata.MealName;
                    item.Description = newmenudata.Description;
                    item.Price = newmenudata.Price;
                    item.Ingredients = newmenudata.Ingredients;

                    return true;

                }
                
            }
            return false;



        }
        public bool DeleteMenuItems(Menu oldMenuItems)
        {
            bool deleteItem = _menuDirectory.Remove(oldMenuItems);
            return deleteItem;
        }

    }
}
