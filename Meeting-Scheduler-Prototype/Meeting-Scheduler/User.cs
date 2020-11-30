using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    class User
    {
        private string userName;
        private string yourMeetings;
        private string proposedMeetings;
        private string sheduledMeetings;
        public User(string user) {//will need objects for each meeting i guess along with a place where that info is storedf
            userName = user;
        }

        public void newMeeting(string title, string desc, string participants, DateTime[] slots)//flexible depending of how we store the data rather than void it could be bool depends
        {
            //sql insert pass in title, desc, participants
            foreach (DateTime slot in slots)
            {
                //sql insert pass in slot
            }
        }

        public void editMeeting(string location, DateTime[] exclusionSet, DateTime[] preferedSet) { 
            //this section
        }
    }
}
