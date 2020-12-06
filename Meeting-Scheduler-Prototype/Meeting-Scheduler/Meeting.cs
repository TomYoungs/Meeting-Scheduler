using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    public class Meeting
    {
        public string title { get; set; }
        public string desc { get; set; }
        public List<string> participants { get; set; }
        public List<DateTime> slots { get; set; }
        public string initiator { get; set; }
        public string equipment { get; set; }
        public string location { get; set; }

        public Meeting(string ltitle, string ldesc,string linitiator, List<string> lparticipants, List<DateTime> lslots,string llocation,string lequipment) //l meaning local
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
