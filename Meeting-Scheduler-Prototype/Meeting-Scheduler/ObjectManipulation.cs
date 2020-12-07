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

        //todo: create class to retrive all created user (there names)
    }
}
