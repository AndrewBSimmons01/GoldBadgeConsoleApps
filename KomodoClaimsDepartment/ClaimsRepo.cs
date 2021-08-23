using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ClaimsRepo
        
    {
        protected readonly List<ClaimClass> _claimDirectory = new List<ClaimClass>();
        //create

        //Read
        public List<ClaimClass> GeClaims()
        {
            return _claimDirectory;
        }
        public ClaimClass GetClaimByID(int claimID)
        {   
            //List<ClaimClass> ClaimIDs = new List<ClaimClass>();
            foreach (ClaimClass item in _claimDirectory)
            {
                Convert.ToString(claimID);
                if (item.ClaimID == claimID)
                    {
                    Convert.ToString(item); 
                        return item;
                    }
            }
            return null;
        }
        
        
        
    }
}
