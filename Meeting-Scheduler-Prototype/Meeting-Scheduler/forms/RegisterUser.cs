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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                submitErrorLabel.Text = "";
               /* List<string> testParticipants = new List<string>();
                testParticipants.Add("x");
                testParticipants.Add("x");

                List<DateTime> testSlots = new List<DateTime>();
                DateTime date = new DateTime(11, 11, 11);
                testSlots.Add(date);
                testSlots.Add(date);
                Meeting test = new Meeting("x", "x", "you", testParticipants, testSlots, "earth", "nothing");*/

                List<Meeting> yourM = new List<Meeting>();
                List<Meeting> proposedM = new List<Meeting>();
                List<Meeting> sheduledM = new List<Meeting>();
                User newUser = new User(txtUsername.Text, txtPassword.Text, yourM, proposedM, sheduledM);
                ObjectManipulation.JSON_Serialized(newUser);
                this.Hide();
            }
            else { submitErrorLabel.Text = "error with submit"; }
        }
    }
}
