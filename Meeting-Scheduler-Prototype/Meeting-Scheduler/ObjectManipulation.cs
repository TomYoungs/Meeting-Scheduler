using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler
{
    class ObjectManipulation
    {
        public User currentUserObject;
        public ObjectManipulation() {
            JSON_Deserialized();//deserialize JSON and pass it into variable currentUserObject

        }

        public void JSON_Deserialized()
        {
            //grab JSON
            //Desirialise (using classes Meeting and User)
            //todo:(JESS) currentUserObject = new User();//<- insert JSON! *************       
        }
        public void JSON_Serialized()
        {
            //serialize object into the JSON file, you may need to re write the entire thing or just add to it not sure
        }
    }
}
