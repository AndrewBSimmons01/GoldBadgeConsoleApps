using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ClaimClass
    {
        public string ClaimID { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
       
        public bool IsValid
        {
            get
            {
                if((DateOfClaim.Date - DateOfIncident.Date).Days > 30)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }
          
        public ClaimType ClaimType { get; set; }
       

        public ClaimClass() { }
        public ClaimClass(string claimID, ClaimType claimType, string description, double claimAmount, DateTime dateOfIncident , DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            
        }
    }
    public enum ClaimType { Car = 1, Home, Theft, NA }
}
