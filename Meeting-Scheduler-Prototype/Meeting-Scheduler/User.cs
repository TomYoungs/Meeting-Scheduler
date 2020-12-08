using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    public class User
    {
        public string userName { get; set; }
        public string Password { get; set; }
        public List<Meeting> yourMeetings { get; set; }
        public List<Meeting> proposedMeetings { get; set; }//might not these two 
        public List<Meeting> sheduledMeetings { get; set; }//    |
        public User(string user, string pass,List<Meeting> lyourMeetings, List<Meeting> lproposedMeetings, List<Meeting> lsheduledMeetings) {
            yourMeetings = new List<Meeting>();
            proposedMeetings = new List<Meeting>();
            sheduledMeetings = new List<Meeting>();
            userName = user;
            Password = pass;
            yourMeetings = lyourMeetings;
            proposedMeetings = lproposedMeetings;
            sheduledMeetings = lsheduledMeetings;
        } 
        public void addMeeting(Meeting addM)
        {
            //maybe a check, assert, try catch?
            yourMeetings.Add(addM);
        }

        public void addProposedMeeting(Meeting addM)
        {
            proposedMeetings.Add(addM);
        }
        public void removeProposedMeeting(Meeting addM)
        {
            proposedMeetings.Remove(addM);
        }
        public void addSheduledMeeting(Meeting addM)
        {
            sheduledMeetings.Add(addM);
        }
        public void acceptSheduledMeeting(string meetingName)
        {
            for (int i = 0; i < proposedMeetings.Count; i++)
            {
                if(proposedMeetings[i].title == meetingName)
                {
                    addSheduledMeeting(proposedMeetings[i]);
                    removeProposedMeeting(proposedMeetings[i]);
                }

            }
             
            
        }
    }
}
