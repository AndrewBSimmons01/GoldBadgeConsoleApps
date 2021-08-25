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
        public void Run()
        {
            MainMenu();
        }
        public void MainMenu()
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
                    Exit();
                    Console.Clear();
                    Console.WriteLine("GoodBye!");
                    Thread.Sleep(400);
                    break;

            }
        }
        public void AddABadge()
        {

        }
        public void EditABAdge()
        {

        }
        public void ListAllBadges()
        {

        }
        public void Exit()
        {

        }
    }
}
