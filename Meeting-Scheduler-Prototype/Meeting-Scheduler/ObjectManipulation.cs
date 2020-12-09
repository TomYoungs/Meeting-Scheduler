using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Meeting_Scheduler
{
    public static class ObjectManipulation
    {
        // public User currentUserObject;
       // public static User currentUser;   //might be redundant       
        public static ListUsers UserCollection;
        public static int CurrentUserIndex;
        

        public static void JSON_Serialized(ListUsers UserCollection)
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
            string JsonUser = JsonConvert.SerializeObject(UserCollection);
            System.IO.File.WriteAllText("JSONdata/collection.json", JsonUser);//might wanna to a check on this not sure
        }
        public static void JSON_Deserialized()
        {
            string JSONstring = System.IO.File.ReadAllText("JSONdata/collection.json");
            UserCollection = JsonConvert.DeserializeObject<ListUsers>(JSONstring);
        }
        public static void updateProposedMeetings(List<string> participants, Meeting newMeeting)
        {
            foreach (string parti in participants)
            {
                for (int userCounter = 0; userCounter < UserCollection.listOfUsers.Count; userCounter++)
                {
                    if (!(UserCollection.listOfUsers[CurrentUserIndex].userName == parti)){
                        if (UserCollection.listOfUsers[userCounter].userName == parti)
                        {
                            UserCollection.listOfUsers[userCounter].addProposedMeeting(newMeeting);
                        }
                    }   
                }
            }

        }
        public static bool timeIsAvailable(DateTime chosenTime)
        {
            for (int userCounter = 0; userCounter < UserCollection.listOfUsers.Count; userCounter++)
            {
                foreach (Meeting item in UserCollection.listOfUsers[userCounter].yourMeetings)
                {
                    if (item.slots.Contains(chosenTime))//todo: needs to be within an hour
                    {
                        return false;
                    }
                }     
            }
            return true;
        }

        public static List<string> getParticipantsList()
        {
            List<string> participants = new List<string>();
            foreach (User item in UserCollection.listOfUsers)
            {
                participants.Add(item.userName);
            }
            return participants;
        }
        
        public static (bool, DateTime) isLocationValid(string checkLocation, List<DateTime> slots)//double return ooooo
        {
            for (int userCounter = 0; userCounter < UserCollection.listOfUsers.Count; userCounter++)
            {
                foreach (Meeting item in UserCollection.listOfUsers[userCounter].yourMeetings)
                {
                    foreach (DateTime time in slots)
                    {
                        if(item.location == checkLocation)
                        {
                            foreach (DateTime slot in item.slots)//slot is the search slot whereas time is the slot passes in (selected)
                            {
                                if(slot.Hour == time.Hour)//assume each meeting is upwards of an hour
                                {
                                    return (false, time);
                                }
                            }
                        }
                    }
                }
            }
            DateTime t1 = new DateTime();
            return (true,t1);
        }
    }
}
