using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ClaimsRepo

    {
        protected readonly Queue<ClaimClass> _claimDirectory = new Queue<ClaimClass>();
        //create
        public bool CreateClaim(ClaimClass content)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Enqueue(content);
            bool wasadded = _claimDirectory.Count > startingCount;
            return wasadded;
        }

        //Read
        public Queue<ClaimClass> GetClaims()
        {
            return _claimDirectory;
        }
        public ClaimClass GetClaimByID(string claimID)
        {
            //List<ClaimClass> ClaimIDs = new List<ClaimClass>();
            foreach (ClaimClass item in _claimDirectory)
            {
                
                if (item.ClaimID == claimID)
                {
                    
                    return item;
                }
            }
            return null;
        }
        //update
        public bool  UpdateClaim(string oldData, ClaimClass newData)
        {
            
            ClaimClass oldDatas = GetClaimByID(oldData);
            if(oldDatas != null)
            {
                oldDatas.ClaimID = newData.ClaimID;
                oldDatas.ClaimType = newData.ClaimType;
                oldDatas.Description = newData.Description;
                oldDatas.ClaimAmount = newData.ClaimAmount;
                oldDatas.DateOfIncident = newData.DateOfIncident;
                
                return true;
            }
            return false;
        }
        public bool DeleteClaim(ClaimClass oldData)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Dequeue();
            bool wasadded = _claimDirectory.Count > startingCount;
            return wasadded;
            
        }
            

            





    }
}
