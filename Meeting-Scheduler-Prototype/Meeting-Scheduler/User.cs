using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    class User
    {
        private string userName;
        private List<Meeting> yourMeetings;
        private List<Meeting> proposedMeetings;
        private List<Meeting> sheduledMeetings;
        public User(string user,List<Meeting> lyourMeetings, List<Meeting> lproposedMeetings, List<Meeting> lsheduledMeetings) {
            userName = user;
            yourMeetings = lyourMeetings.ToList();
            proposedMeetings = lproposedMeetings.ToList();
            sheduledMeetings = lsheduledMeetings.ToList();
        }

        public void newMeeting(string title, string desc, string participants, DateTime[] slots)//flexible depending of how we store the data rather than void it could be bool depends
        {
            //participants
            //pref set
            //ex set
            //location
            //equipment
            foreach (DateTime slot in slots)
            {
                
            }
        }

        public void editMeeting(string location, DateTime[] exclusionSet, DateTime[] preferedSet) { 
            //this section
        }
    }
}
