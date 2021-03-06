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
                List<Meeting> yourM = new List<Meeting>();
                List<Meeting> proposedM = new List<Meeting>();
                List<Meeting> sheduledM = new List<Meeting>();
               
                User newUser = new User(txtUsername.Text, txtPassword.Text, yourM, proposedM, sheduledM);
                ObjectManipulation.UserCollection.listOfUsers.Add(newUser);
                ObjectManipulation.JSON_Serialized(ObjectManipulation.UserCollection);
                this.Close();
            }
            else { submitErrorLabel.Text = "error with submit"; }
        }
    }
}
