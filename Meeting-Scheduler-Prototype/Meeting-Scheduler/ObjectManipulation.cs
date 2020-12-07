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
        public static User currentUser;          

        public static void JSON_Serialized(User currentUser)
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
            string JsonUser = JsonConvert.SerializeObject(currentUser);
            System.IO.File.WriteAllText("JSONdata/"+ currentUser.userName+".json", JsonUser);//might wanna to a check on this not sure

        }
        public static void JSON_Deserialized(string userName)
        {
            string JSONstring = System.IO.File.ReadAllText("JSONdata/" + userName + ".json");
            currentUser = JsonConvert.DeserializeObject<User>(JSONstring);
            //Desirialise (using classes Meeting and User)
            //todo:(JESS) currentUserObject = new User();//<- insert JSON! *************       
        }

        //todo: create class to retrive all created user (there names)
    }
}
