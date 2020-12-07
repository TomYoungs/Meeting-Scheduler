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
           
            ObjectManipulation.JSON_Deserialized("mehmet");//todo: use ObjectManipulation.currentUser.userName;
            //*******not very happy with this code might be better to do it with if statements or something maybe a special function for doing this idk
            try { userMeetingsCBox.Items.Add(ObjectManipulation.currentUser.yourMeetings.ElementAt(0)); }//becuase you can't pass in NULL into a text box you need to catch the error
            catch (Exception){ userMeetingsCBox.Items.Add("no meetings found..."); }

            try { userProposedMeetingsCBox.Items.Add(ObjectManipulation.currentUser.proposedMeetings.ElementAt(0)); }
            catch (Exception) { userProposedMeetingsCBox.Items.Add("no meetings found..."); }

            try { userSheduledMeetingsCBox.Items.Add(ObjectManipulation.currentUser.sheduledMeetings.ElementAt(0)); }
            catch (Exception) { userSheduledMeetingsCBox.Items.Add("no meetings found..."); }
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
