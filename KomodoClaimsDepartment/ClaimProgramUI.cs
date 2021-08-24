using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ClaimProgramUI

    {
        private readonly ClaimsRepo _repo = new ClaimsRepo();
        DateTime dt2 = new DateTime(2015, 12, 31);
        public void Run()
        {
            {

                seedItems();
                Menu();
            }
        }
        
        public void seedItems()
        {
            ClaimClass cc1 = new ClaimClass(001, ClaimType.Home, "Electrical fire started in garage. Home is destroyed", 115000.68, new DateTime(2001, 2, 22), new DateTime(2001, 2, 23), true);
            ClaimClass cc2 = new ClaimClass(002, ClaimType.Home, "Auto  Accident. Head-on. Driver did not survive.", 13000.22, new DateTime(2010, 5, 1), new DateTime(2010, 5, 5), true);

        }
        public void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Claims Agent Menu\n\n\n\n" +
                    "Select Action\n\n\n" +
                    "1:See all claims\n\n" +
                    "2:Take Care Of Next Claim\n\n" +
                    "3:Enter A New Claim\n\n" +
                    "4:Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        DisplayAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Selection");
                        Console.ReadKey();
                        break;

                }
            }
            Console.Clear();
            Console.WriteLine("Don't Forget To Clock Out!");
            Thread.Sleep(1300);
        }
        public DateTime UserEnterDateTime()
        {
            Console.WriteLine("Day: ");
            var day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Month: ");
            var month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Month: ");
            var year = Convert.ToInt32(Console.ReadLine());



            return new DateTime(month, day, year);
        }
    }
}
