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
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*string username = "Tom";//todo:bind this to relivant user;
            List<string> parti = new List<string>();
            parti.Add("Jess");
            DateTime date1 = new DateTime(2015, 12, 25);
            DateTime date2 = new DateTime(2015, 12, 25);
            List<DateTime> tmpslots = new List<DateTime>();
            tmpslots.Add(date1);
            tmpslots.Add(date2);*/
            //todo:prob gonna need to validate values if we have the time
            //List<object> participants = checkedListParticipants.CheckedItems.IndexOf();

           Meeting newMeeting = new Meeting(txtTitle.Text, txtDesc.Text, ObjectManipulation.currentUser.userName, participants, slots,txtLocation.Text, txtEquipment.Text);
            //add meeting to user object
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            checkedListSlots.Items.Add(dataTimePicker.Value);
            slots.Add(dataTimePicker.Value);
        }
    }
}
