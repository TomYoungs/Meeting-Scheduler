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
        public string userName;
        private List<Meeting> yourMeetings;
        public List<Meeting> proposedMeetings;//might not these two 
        public List<Meeting> sheduledMeetings;//    |
        public User(string user,List<Meeting> lyourMeetings, List<Meeting> lproposedMeetings, List<Meeting> lsheduledMeetings) {
            userName = user;
            yourMeetings = lyourMeetings.ToList();
            proposedMeetings = lproposedMeetings.ToList();
            sheduledMeetings = lsheduledMeetings.ToList();
        }
        public List<Meeting> getYourMeetings()
        {
            return yourMeetings;
        }
        public void addMeeting(Meeting addM)
        {
            //maybe a check, assert, try catch?
            yourMeetings.Add(addM);
        }
    }
}
