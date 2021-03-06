﻿using System;
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
            try
            {
                ObjectManipulation.JSON_Deserialized();
            }
            catch (Exception)
            {
                ObjectManipulation.JSON_Serialized(null);
            }        
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
            if(ObjectManipulation.UserCollection != null) { // is textbox empty?
                loginErrorLabel.Text = "";
                String searchName = username.Text; // username check variable
                String searchPW = password.Text; // password check variable
                int counter = 0;
                bool leavingCondition = true;

                int listLength = ObjectManipulation.UserCollection.listOfUsers.Count(); // finds the length of users list (currently 6)


                while (leavingCondition)
                {
                    if (listLength == counter)
                    {
                        loginErrorLabel.Text = "login failed";
                        leavingCondition = false;
                    }
                    else if (ObjectManipulation.UserCollection.listOfUsers[counter].userName == searchName)
                    {
                        if (ObjectManipulation.UserCollection.listOfUsers[counter].Password == searchPW)
                        {
                            ObjectManipulation.CurrentUserIndex = counter;
                            this.Hide();
                            home f1 = new home();
                            f1.Show();
                            leavingCondition = false;
                        }
                        else
                        {
                            loginErrorLabel.Text = "password incorrect";
                            leavingCondition = false;
                        }
                    }
                    else if (ObjectManipulation.UserCollection.listOfUsers[counter].userName != searchName)
                    {
                        
                        leavingCondition = true;
                    }
                    counter++;
                }


            }
            else
            {
                loginErrorLabel.Text = "please create a user";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        
            RegisterUser f1 = new RegisterUser();
            f1.Show();
        }
    }
}
