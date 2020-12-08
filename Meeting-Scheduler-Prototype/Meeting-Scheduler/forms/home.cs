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
            //todo: use ObjectManipulation.currentUser.userName;
                                           
            try//problem here with the concurrency proposed meetings dont appear when the user doesn't have any of there own meetings
            {

                //proposed meetings
                //ObjectManipulation.CurrentUserIndex
                //prob could make this more simple but idk
                foreach (User item in ObjectManipulation.UserCollection.listOfUsers)
                {
                    if (item.userName != ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].userName)
                    {
                        string mainName = ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].userName;
                        for (int i = 0; i < item.yourMeetings.Count; i++)
                        {
                            if (!(ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].proposedMeetings.Contains(item.yourMeetings[i])) && item.yourMeetings[i].participants.Contains(mainName))//does the participants list contain mainName? and does this meeting already exist in participants
                            {
                                ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].addProposedMeeting(item.yourMeetings[i]);
                            }
                            
                            
                        }

                    }
                }

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

                
                    
                    //sheduled meetings

            }
            catch (Exception){ errorLabel.Text = "no meetings found..."; }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            newMeeting f1 = new newMeeting();
            f1.Show();
            this.Close();
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

        private void checkedListYourM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListProposedM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
