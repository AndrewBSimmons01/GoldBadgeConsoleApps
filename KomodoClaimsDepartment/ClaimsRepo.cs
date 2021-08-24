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
        public bool CreateClaim(ClaimClass content)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Add(content);
            bool wasadded = _claimDirectory.Count > startingCount;
            return wasadded;
        }

        //Read
        public List<ClaimClass> GetClaims()
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
        //update
        public bool  UpdateClaim(string oldData, ClaimClass newData)
        {
            
            ClaimClass oldDatas = GetClaimByID(Convert.ToInt32(oldData));
            if(oldDatas != null)
            {
                oldDatas.ClaimID = newData.ClaimID;
                oldDatas.ClaimType = newData.ClaimType;
                oldDatas.Description = newData.Description;
                oldDatas.ClaimAmount = newData.ClaimAmount;
                oldDatas.DateOfIncident = newData.DateOfIncident;
                oldDatas.IsValid = newData.IsValid;
                return true;
            }
            return false;
        }
        public bool DeleteClaim(ClaimClass oldData)
        {
            bool deleteClaim = _claimDirectory.Remove(oldData);
            return deleteClaim;
        }
            

            





    }
}
