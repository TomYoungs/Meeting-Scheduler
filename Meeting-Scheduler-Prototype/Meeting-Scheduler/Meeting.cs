using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    class Meeting
    {
        public string title;
        public string desc;
        public List<string> participants;
        public List<DateTime> slots;
        public string initiator;
        public string equipment;
        public string location;

        public Meeting(string ltitle, string ldesc,string linitiator, string[] lparticipants, DateTime[] lslots,string llocation,string lequipment) //l meaning local
        {
            initiator = linitiator;
            participants = new List<string>();
            slots = new List<DateTime>();
            title = ltitle;
            desc = ldesc;
            location = llocation;
            equipment = lequipment;
            participants = lparticipants.ToList();
            slots = lslots.ToList();
        }
        public void editParticipants()//could be bool we shall see
        {

        }
        public void editTime() {
        }


        public void editMeeting(Meeting userMeeting)//might have to pass in like a ID or something not sure
        {
            //this section
        }
    }
}
