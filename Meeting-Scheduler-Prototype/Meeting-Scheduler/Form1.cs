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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            string[] dropDownContent = { "James", "Jess", "Tom","Jordan","George","Jasper","Theo" };
            for (int i = 0; i < dropDownContent.Length; i++) { 
                dropdownUsers.Items.Add(dropDownContent[i]);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Object selectedItem = dropdownUsers.SelectedItem;
        }
    }
}
