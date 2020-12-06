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
        public static string JSON_Serialized(User newUser)
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
            string JsonUser = JsonConvert.SerializeObject(newUser);
            return JsonUser;
            
            //return JsonConvert.SerializeObject(newUser);
        }
        public static Object JSON_Deserialized(string JsonUser)
        {
            User deserializedUser = JsonConvert.DeserializeObject<User>(JsonUser);
            return deserializedUser;

            //Desirialise (using classes Meeting and User)
            //todo:(JESS) currentUserObject = new User();//<- insert JSON! *************       
        }
    }
}
