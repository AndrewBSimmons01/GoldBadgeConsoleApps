using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApps
{
    class Menu
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Menu(string mealName, int mealNumber, string description, double price, string ingredients)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            Description = description;
            Price = price;
            Ingredients = ingredients;

        }
    }
}
