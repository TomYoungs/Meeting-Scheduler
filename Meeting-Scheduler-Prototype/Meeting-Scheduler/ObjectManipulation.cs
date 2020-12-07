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
        public static void JSON_Serialized(User newUser)
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
            string JsonUser = JsonConvert.SerializeObject(newUser);
            System.IO.File.WriteAllText("JSONdata/"+newUser.userName+".json", JsonUser);//might wanna to a check on this not sure

        }
        public static User JSON_Deserialized(string userName)
        {
            string JSONstring = System.IO.File.ReadAllText("JSONdata/" + userName + ".json");
            User temp =   JsonConvert.DeserializeObject<User>(JSONstring);
            return temp;

            //Desirialise (using classes Meeting and User)
            //todo:(JESS) currentUserObject = new User();//<- insert JSON! *************       
        }
    }
}
