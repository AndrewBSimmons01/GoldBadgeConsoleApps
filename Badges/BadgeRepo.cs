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
        public List<Badge> BadgeNumbers = new List<Badge>();
        //Create
        public void AddBadge(Badge badge)
        {
            //int startingcount = _BadgeDirectory.Count;
            _BadgeDirectory.Add(badge.BadgeID, badge.DoorAccess);
            BadgeNumbers.Add(badge);
            
        }
        //Read
        //public List<Badge> getcontents()
        public List<Badge> getcontents()
        {
            //List<KeyValuePair<string , List<string> list = _BadgeDirectory.ToList();
            //listcontent = 
            //return _BadgeDirectory;
            return BadgeNumbers;
        }
        public KeyValuePair<int, List<string>> GetContentsById( int badgeId)
        {
            foreach(KeyValuePair<int, List<string>> item in _BadgeDirectory)
            {
                if (item.Key == badgeId)
                {
                    return item;
                }
            }
            return default;
        }
        //Update
        public bool UpdateBadgeDoors(int Id, Badge newBadge)
        {
            KeyValuePair<int, List<string>> oldBadge = GetContentsById(Id);
            if (oldBadge.Key != null)
            {
                return oldBadge
            }
            oldBadge.BadgeID = newBadge.BadgeID;
            oldBadge.DoorAccess = newBadge.DoorAccess;
        }
        //Delete
        public void DeleteAllDoors(Badge badge)
        {
            _BadgeDirectory.Remove(Convert.ToInt32(badge.DoorAccess));
        }
        
    }
}
