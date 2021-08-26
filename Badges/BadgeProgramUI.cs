using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Badges
{
    class BadgeProgramUI
    {
      
        protected readonly BadgeRepo _repo = new BadgeRepo();
       
      
        public void Run()
        {
            SeedItems();
            MainMenu();
        }
       
        public void SeedItems()
        {
            Badge b1 = new Badge(1, new List<string> { "Door 1", "Door 2", "Door 3", "Door 4" });
            _repo.AddBadge(b1);
        }
        public void MainMenu()
        {
            bool running = true;
            while (running)
            {


                Console.WriteLine("Admin Menu\n\n" +
                    "Hello Security Admin What Would You Like To Do?\n\n" +
                    "1.Add A Badge\n" +
                    "2.Edit A Badge\n" +
                    "3. List All Badges");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABAdge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        running = false;
                        Console.Clear();
                        Console.WriteLine("GoodBye!");
                        Thread.Sleep(400);
                        break;

                }
            }
        }
        public void AddABadge()
        {
            Console.Clear();
            Badge badge = new Badge();
            bool running = true;
            while (running)
            {


                Console.WriteLine("Badge ID: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1000)
                {
                    Console.WriteLine("Enter Valid Badge ID");
                }
                else
                {
                    badge.BadgeID = input;
                }
                Console.Clear();
                Console.WriteLine("What Doors Does This Badge Access?");
                string badgedoor = Console.ReadLine();
                if (string.IsNullOrEmpty(badgedoor))
                {
                    Console.WriteLine("Enter Valid Door Name");
                }
                else
                {
                    badge.DoorAccess.Add(badgedoor);
                }


            }
           

        }
        public void EditABAdge()
        {
            Console.Clear();
            Console.WriteLine("What Badge Number Needs Updated?");
            ListAllBadges();
            int badgenumber = Convert.ToInt32(Console.ReadLine());
            KeyValuePair<int , List<string>> badges = _repo.GetContentsById(badgenumber);
            foreach (string item in badges.Value)
            {
            Console.WriteLine($"{badgenumber} has access to doors {item}");
                
            }
            Console.WriteLine("What would you like to do?\n" +
                "1. Remove A Door.\n" +
                "2. Add A Door.\n\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RemoveADoor();
                    break;
                case "2":
                    AddADoor();
                    break;
                default:
                    Console.WriteLine("Make Valid Selection");
                    break;
            }

            
         
        }
        public void ListAllBadges()
        {
            List<Badge> badges = _repo.getcontents();
            foreach(Badge item in badges)
            {
                DisplayBadges(item);
            }
            Console.ReadKey();
            Console.WriteLine("Any Key To Continue");
        }
        public void DisplayBadges(Badge item)
        {
            Console.WriteLine($"Badge Number: {item.BadgeID} \n" +
                $"Doors: {item.DoorAccess}\n");
            
        }
        
        //public static Badge doors = new Badge (new List<string> { "door 1", "door 2", "door3", "door 4" });
    }
}
