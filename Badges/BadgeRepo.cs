using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    class BadgeRepo
    {
        protected readonly Dictionary <int, List<string>> _BadgeDirectory = new Dictionary<int, List<string>>();
        
        //Create
        public void AddBadge(Badge badge)
        {
            //int startingcount = _BadgeDirectory.Count;
            _BadgeDirectory.Add(badge.BadgeID, badge.DoorAccess);
            
        }
        //Read
        //public List<Badge> getcontents()
        public void getcontents()
        {
            //List<KeyValuePair<string , List<string> list = _BadgeDirectory.ToList();
            //listcontent = 
            //return _BadgeDirectory;
            Console.WriteLine(_BadgeDirectory);
        }
        //Update
        public void UpdateBadgeDoors(Badge badge)
        {
            
        }
        //Delete
        public void DeleteAllDoors(Badge badge)
        {
            _BadgeDirectory.Remove(Convert.ToInt32(badge.DoorAccess));
        }
        
    }
}
