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
        public List<Meeting> yourMeetings;
        public List<Meeting> proposedMeetings;
        public List<Meeting> sheduledMeetings;
        public User(string user,List<Meeting> lyourMeetings, List<Meeting> lproposedMeetings, List<Meeting> lsheduledMeetings) {
            userName = user;
            yourMeetings = lyourMeetings.ToList();
            proposedMeetings = lproposedMeetings.ToList();
            sheduledMeetings = lsheduledMeetings.ToList();
        }
         
    }
}
