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
        string[] locations = { "Room 1", "Room 2", "Cafe", "Office", "lounge" };
        public newMeeting()
        {
            InitializeComponent();
        }
        private void newMeeting_Load(object sender, EventArgs e)
        {
            participants = ObjectManipulation.getParticipantsList();
            foreach (string user in participants)
            {
                checkedListParticipants.Items.Add(user);
            }

            foreach (string place in locations)
            {
                checkedListLocations.Items.Add(place);
            }
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> selectedParticipants = new List<string>(); 
            foreach (string item in checkedListParticipants.CheckedItems)
            {
                selectedParticipants.Add(item);
            }
            /*string loc;
            foreach (string item in )
            {
                string loc = item;
            }*/

            (bool,DateTime) validBoolTime = ObjectManipulation.isLocationValid(checkedListLocations.CheckedItems[0].ToString(), slots);
            if (validBoolTime.Item1)
            {
                string selectedLocation = (checkedListLocations.CheckedItems[0]).ToString();
                Meeting newMeeting = new Meeting(txtTitle.Text, txtDesc.Text,
                ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].userName,
                selectedParticipants, slots, selectedLocation, txtEquipment.Text);

                ObjectManipulation.UserCollection.listOfUsers[ObjectManipulation.CurrentUserIndex].addMeeting(newMeeting);
                ObjectManipulation.updateProposedMeetings(selectedParticipants, newMeeting);
                ObjectManipulation.JSON_Serialized(ObjectManipulation.UserCollection);
                this.Hide();
                home f1 = new home();
                f1.Show();
            }
            else
            {
                locationErrorLabel.Text = "location is not available at time '" + validBoolTime.Item2 + "' please re-enter";
            }
              
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ObjectManipulation.timeIsAvailable(dataTimePicker.Value))
            {
                timeSlotError.Text = "";
                checkedListSlots.Items.Add(dataTimePicker.Value);
                slots.Add(dataTimePicker.Value);
            }
            else { timeSlotError.Text = "time slot taken"; }
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
        private void checkedListParticipants_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
