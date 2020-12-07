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

        private void label1_Click(object sender, EventArgs e)
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
            ObjectManipulation.JSON_Deserialized();
            String searchName = username.Text;
            int counter = 0;
            bool leavingCondition = true;
            while (leavingCondition)
            {
                if(ObjectManipulation.UserCollection.listOfUsers[counter].userName == searchName)
                {
                    ObjectManipulation.CurrentUserIndex = counter;
                    this.Hide();
                    home f1 = new home();
                    f1.Show();
                    leavingCondition = false;
                }
                else if(ObjectManipulation.UserCollection.listOfUsers[counter].userName == null)
                {
                    leavingCondition = false;
                }
            }
            leavingCondition = true;


            //if statement here if (textbox1.Text.Length > 0)
            /* if (username.Text == "Mehmet" && password.Text == "Ozcan123")
             {

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
             }*/
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        
            RegisterUser f1 = new RegisterUser();
            f1.Show();
        }
    }
}
