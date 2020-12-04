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
            //here goes all the data dump stuff (user info etc...) seperate class for objectManipulation (serilizing and de)

            //1) deserialize JSON (in another function)
            ObjectManipulation userJSON = new ObjectManipulation();
            //User userInfo = new User();

            //3) populate!
            
            userMeetingsCBox.Items.Add("test");//prob gonna be in a loop
            userProposedMeetingsCBox.Items.Add("test");
            userSheduledMeetingsCBox.Items.Add("test");
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
