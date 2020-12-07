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
    public partial class newMeeting : Form
    {
        List<DateTime> slots = new List<DateTime>();
        List<string> participants = new List<string>();
        public newMeeting()
        {
            InitializeComponent();
        }
        private void newMeeting_Load(object sender, EventArgs e)
        {
            string[] userlist = { "Tom", "Jess", "James", "Mehmet" };
            foreach (string user in userlist)
            {
                checkedListParticipants.Items.Add(user);
                participants.Add(user);
            }
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Meeting newMeeting = new Meeting(txtTitle.Text, txtDesc.Text, ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].userName, participants, slots,txtLocation.Text, txtEquipment.Text);
            ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].addMeeting(newMeeting);
            ObjectManipulation.JSON_Serialized(ObjectManipulation.UserCollection);

            this.Hide();
            home f1 = new home();
            f1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkedListSlots.Items.Add(dataTimePicker.Value);
            slots.Add(dataTimePicker.Value);
        }
        private void checkedListParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListSlots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
