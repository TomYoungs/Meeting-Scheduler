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
        public newMeeting()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = "Tom";//todo:bind this to relivant user;
            string[] parti = { "Tom", "Jess", "James" };
            DateTime date1 = new DateTime(2015, 12, 25);
            DateTime date2 = new DateTime(2015, 12, 25);
            DateTime[] tmpslots = { date1, date2 };
            //todo:prob gonna need to validate values if we have the time
            Meeting newMeeting = new Meeting(txtTitle.Text, txtDesc.Text,username,parti,tmpslots,txtLocation.Text, txtEquipment.Text);
            //todo: user.addMeeting(newMeeting); <- need to add user
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
