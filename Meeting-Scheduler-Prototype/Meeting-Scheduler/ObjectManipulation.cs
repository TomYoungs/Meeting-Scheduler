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

        public static void JSON_Deserialized()
        {
            //grab JSON
            //Desirialise (using classes Meeting and User)
            //todo:(JESS) currentUserObject = new User();//<- insert JSON! *************       
        }
        public static string JSON_Serialized(User newUser)
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
            return JsonConvert.SerializeObject(newUser);
        }
    }
}
