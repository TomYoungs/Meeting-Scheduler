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
            this.Hide();
            home f1 = new home();
            f1.Show();
        }
    }
}
