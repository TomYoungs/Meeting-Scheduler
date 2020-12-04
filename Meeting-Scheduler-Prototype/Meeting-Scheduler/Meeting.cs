using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    class Meeting
    {
        private string title;
        private string desc;
        private List<User> participants;
        private List<DateTime> slots;
        private User initiator;

        public Meeting(string ltitle, string ldesc,User linitiator, User[] lparticipants, DateTime[] lslots) //l meaning local
        {
            initiator = linitiator;
            participants = new List<User>();
            slots = new List<DateTime>();
            title = ltitle;
            desc = ldesc;
            participants = lparticipants.ToList();
            slots = lslots.ToList();
        }
        public void editParticipants()//could be bool we shall see
        {

        }
        public void editTime() {
        }
    }
}
