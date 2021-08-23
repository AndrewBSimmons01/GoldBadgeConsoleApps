using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ClaimProgramUI

    {
        private readonly ClaimsRepo _repo = new ClaimsRepo();
        public void Run()
        {
            {

                SeedItems();
                Menu();
            }
        }
        public void seedItems()
        {

        }
        public void Menu()
        {

        }
    }
}
