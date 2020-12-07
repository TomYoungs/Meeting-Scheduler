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
                User newUser = new User(txtUsername.Text, txtPassword.Text, null, null, null);
                ObjectManipulation.JSON_Serialized(newUser);
                this.Hide();
            }
            else { submitErrorLabel.Text = "error with submit"; }
        }
    }
}
