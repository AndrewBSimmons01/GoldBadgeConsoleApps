using System;
using System.Collections;
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
        //DateTime dt2 = new DateTime(2015, 12, 31);
        public void Run()
        {
         SeedItems();
         Menu();
         }
        
        public void SeedItems()
        {
            
            ClaimClass cC1 = new ClaimClass("001", ClaimType.Home, "Electrical fire started in garage. Home is destroyed", 115000.68, new DateTime(2001, 2, 22), new DateTime(2001, 2, 23), true);
            ClaimClass cC2 = new ClaimClass("002", ClaimType.Car, "Auto  Accident. Head-on. Driver did not survive.", 13000.22, new DateTime(2010, 5, 1), new DateTime(2010, 5, 5), true);
            ClaimClass cC3= new ClaimClass("003", ClaimType.NA, "No Details", 00.00, new DateTime(2021,1,1), new DateTime(2021,1,1), false);
            ClaimClass cC4 = new ClaimClass("004", ClaimType.NA, "No Details", 00.00, new DateTime(2021, 1, 1), new DateTime(2021, 1, 1), false);
            ClaimClass cC5 = new ClaimClass("005", ClaimType.NA, "No Details", 00.00, new DateTime(2021, 1, 1), new DateTime(2021, 1, 1), false);
            _repo.CreateClaim(cC1);
            _repo.CreateClaim(cC2);
            _repo.CreateClaim(cC3);
            _repo.CreateClaim(cC4);
            _repo.CreateClaim(cC5);


        }

        public void TakeCareOfNextClaim()
        {

            Queue<ClaimClass> claims = _repo.GetClaims();
            var viewnext = claims.Peek();
            Console.WriteLine($"Claim ID: {viewnext.ClaimID} \n" +
              $"Type: {viewnext.ClaimID})\n" +
              $"Claim Amount: {viewnext.ClaimAmount}\n" +
              $"Date of Claim: {viewnext.DateOfClaim}\n" +
              $"Date of Incident: {viewnext.DateOfIncident}\n" +
              $"Description: {viewnext.Description}\n\n\n\n");
            Console.WriteLine("Do you want to deal with this claim now?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    claims.Dequeue();
                    break;
                case "n":
                    Console.WriteLine("goodbye");
                    Thread.Sleep(400);
                    break;


            }

        }


        public void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
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
                        AddNewClaim();
                        break;
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
        public void DisplayAllClaims()
        {
            
            Queue<ClaimClass> claims = _repo.GetClaims();
            foreach(ClaimClass claim in claims)
            {
                DisplayClaims(claim);
            }
            
            
        }
        public void DisplayClaims(ClaimClass claim)
        {
            
            Console.WriteLine($"Claim ID: {claim.ClaimID} \n" +
                $"Type: {claim.ClaimType})\n" +
                $"Claim Amount: {claim.ClaimAmount}\n" +
                $"Date of Claim: {claim.DateOfClaim}\n" +
                $"Date of Incident: {claim.DateOfIncident}\n" +
                $"Description: {claim.Description}\n\n\n\n");
            ContinueMessage();
            
            
        }
        public void ContinueMessage()
        {
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
        public int AgeOfClaim(DateTime dateOfClaim, DateTime dateOfIncident)
        {
            var days = dateOfClaim - dateOfIncident;
            return Convert.ToInt32(days);
        } 
          
        public void AddNewClaim()
        {
            Console.Clear();
            ClaimClass claim = new ClaimClass();
            bool isValid = false;
            
            while (!isValid)
            {
                Console.WriteLine("Claim ID: ");
                string claimID = Console.ReadLine();
                if (string.IsNullOrEmpty(claimID))
                {
                    Console.WriteLine("Please Enter valid Claim ID");
                }
                else
                {
                    claim.ClaimID = claimID;
                }
                break;
            }
            Console.Clear();
            Console.Write("Type: 1: Car\n" +
                "2: Home\n" +
                "3:Theft\n" +
                "4: NA\n");
            Console.WriteLine("Enter Type #");
            string typeInput = Console.ReadLine();
            int typeID = int.Parse(typeInput);
            claim.ClaimType = (ClaimType)typeID;

            Console.Clear();
            Console.WriteLine("Claim Amount : ");
            string claimAmount = Console.ReadLine();
            if (string.IsNullOrEmpty(claimAmount))
            {
                Console.WriteLine("Please Enter Valid Amount");
            }
            else
            {
                claim.ClaimAmount = Convert.ToDouble(claimAmount);
            }
            Console.Clear();
            Console.WriteLine("Enter Date Of Incident ex. yyyy/mm/dd");
            string dateOfIncident = Console.ReadLine();
            if (string.IsNullOrEmpty(dateOfIncident))
            {
                Console.WriteLine("Please Enter Valid Date");
            }
            else
            {
                claim.DateOfIncident = Convert.ToDateTime(dateOfIncident);
            }
            Console.Clear();
            Console.WriteLine("Enter Date of Claim ex. yyyy/mm/dd. Date of Claim Must Not Be > 30 Days From Date Of Incident.");
            string dateOfClaim = Console.ReadLine();
            if (string.IsNullOrEmpty(dateOfClaim))
            {
                Console.WriteLine("Please Enter Valid Date");

            }
            else if(!isValid)
            {
                Console.WriteLine("Please Enter Valid Date");
            }
            else
            {
                claim.DateOfClaim = Convert.ToDateTime(dateOfClaim);

            }

            Console.Clear();
            
            Console.Clear();
            Console.WriteLine("Please Enter A Description Of Claim");
            string claimDesription = Console.ReadLine();
            if (string.IsNullOrEmpty(claimDesription))
            {
                Console.WriteLine("Please Enter Valid Description");
            }
            else
            {
                claim.Description = claimDesription;
            }
            _repo.CreateClaim(claim);
            Console.Clear();
            Console.WriteLine("Claim Added");
            Thread.Sleep(299);
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
