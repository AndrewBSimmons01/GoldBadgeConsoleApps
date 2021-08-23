using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApps
{
    public class MenuProgramUI
    {
        private readonly MenuRepoPattern _repo = new MenuRepoPattern();
        public void Run()
        {
            
            SeedItems();
            Menu();
        }
        public void SeedItems()
        {
            Console.WriteLine("Getting Menu...");
            Menu Number1 = new Menu(" Honey Sesame Chicken Breast", 1, "Honey Sesame Chicken Breast is made with thin, crispy\n" +
                " strips of all-white meat chicken tossed with fresh-cut string beans, crisp yellow bell peppers\n" +
                " in a sizzling hot wok with our new delicious honey sauce and topped off with sesame seeds.\n" +
                "", 11.99, "Chicken Strips, String Beans , Bell Peppers , Honey Sauce , Sesame Seeds");
            Menu Number2 = new Menu("Kung Pao Chicken", 2, "A Sichuan-inspired dish with chicken, peanuts and vegetables, finished with chili peppers", 8.99,  "Chicken Breast , Peanuts , Broccoli , Chili Peppers" );
            Menu Number3 = new Menu("Grilled Teriyaki Chicken", 3, "Grilled chicken thigh hand-sliced to order and served with teriyaki sauce.", 9.99, " Sliced Chicken Thigh , Spices , Teriyaki Sauce" );

            _repo.AddMenuContent(Number1);
            _repo.AddMenuContent(Number2);
            _repo.AddMenuContent(Number3);
        }
        public void Menu()
        {
            bool continuetorun = true;
            while (continuetorun)
            {
                Console.Clear();
                Console.WriteLine("Tasty King Wok Modify Menu App\n" +
                    "1. Show Menu Items\n" +
                    "2.Find Menu Items by Meal Number\n" +
                    "3.Add New Menu Items\n" +
                    "4.Remove Menu Items\n" +
                    "5. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayAllMenuItems();
                        break;
                    default:
                        Console.WriteLine("Please enter valid selection");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Later Dude!");
            Thread.Sleep(2000);

             void DisplayAllMenuItems()
            {
                Console.Clear();
                List<Menu> contents = _repo.GetItems();
                foreach(Menu content in contents)
                {
                    DisplayContent(content);
                }
                ContinueMessage();
            }
             void DisplayContent(Menu content)
            {
                Console.WriteLine($"\n\n { content.MealNumber} \n" + 
                    $"\n" +
                    $" { content.MealName}\n\n" +
                    $"" + "$" + $" { content.Price}\n" +
                    $"" +
                    $" { content.Description}\n" +
                    $" {content.Ingredients}\n\n\n\n");
            }
            void ContinueMessage()
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
