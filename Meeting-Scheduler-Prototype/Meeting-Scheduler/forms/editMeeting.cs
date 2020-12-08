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
    public partial class editMeeting : Form
    {
        List<string> participants = new List<string>();
        List<DateTime> slots = new List<DateTime>();
        public editMeeting()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Meeting editMeeting = new Meeting(txtTitle.Text, txtDesc.Text, ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].userName, participants, slots, txtLocation.Text, txtEquipment.Text);
            ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].addMeeting(editMeeting);
            ObjectManipulation.JSON_Serialized(ObjectManipulation.UserCollection);

            this.Hide();
            home f1 = new home();
            f1.Show();
        }

        private void checkedListParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void editMeeting_Load(object sender, EventArgs e)
        {
            txtTitle.Text = "your meeting";
            txtDesc.Text = "meeting description";
            txtEquipment.Text ="Equipment";
            txtLocation.Text = "location";
            string[] userlist = { "Tom", "Jess", "James", "Mehmet", "dave" };
            foreach (string user in userlist)
            {
                checkedListParticipants.Items.Add(user);
                participants.Add(user);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkedListSlots.Items.Add(dataTimePicker.Value);
            slots.Add(dataTimePicker.Value);
        }
    }
}
