using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduler
{
    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {           
            ObjectManipulation.JSON_Deserialized();//todo: use ObjectManipulation.currentUser.userName;
            //todo: format this data correctly |
            //                                 V
            try
            {
                foreach (Meeting item in ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].yourMeetings)
                    {
                        checkedListYourM.Items.Add(item.title); 
                    }//becuase you can't pass in NULL into a text box you need to catch the error

                    foreach (Meeting item in ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].proposedMeetings)
                    {
                        checkedListProposedM.Items.Add(item.title);
                    }
                    foreach (Meeting item in ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].sheduledMeetings)
                    {
                       checkedListSheduledM.Items.Add(item.title);
                    }
            }
            catch (Exception){ errorLabel.Text = "no meetings found..."; }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            newMeeting f1 = new newMeeting();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Preference f1 = new Preference();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editMeeting f1 = new editMeeting();
            f1.Show();
        }

        
    }
}
