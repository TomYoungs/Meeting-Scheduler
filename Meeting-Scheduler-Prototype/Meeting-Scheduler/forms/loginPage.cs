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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if statement here if (textbox1.Text.Length > 0)
            if (username.Text == "Mehmet" && password.Text == "Ozcan123")
            {
                this.Hide();
                home f1 = new home();
                f1.Show();
            }
            else if (username.Text != "Mehmet" && password.Text == "Ozcan123")
            {
                username.Text = "INCORRECT";
            }
            else if (username.Text == "Mehmet" && password.Text != "Ozcan123")
            {
                password.Text = "INCORRECT";
            }
            else
            {
                username.Text = "INCORRECT";
                password.Text = "INCORRECT";
            }
        }
    }
}
