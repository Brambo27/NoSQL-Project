using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showPanel("userManagement");
        }

        private void showPanel(string panelName)
        {
            panel_addUser.Hide();
            panel_userManagement.Hide();

            switch (panelName)
            {
                case "Login": ;
                    break;
                case "userManagement": panel_userManagement.Show();
                    break;
                case "addUser": panel_addUser.Show();
                    break;
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            showPanel("addUser");
        }

        private void cancelAddUser_btn_Click(object sender, EventArgs e)
        {
            showPanel("userManagement");
        }

        private void confirmAddUser_btn_Click(object sender, EventArgs e)
        {
            string[] data = new string[6];

            // see if firstname is empty
            if(firstName_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a First name.";
                showPanel("userManagement");
            } else
            {
                data[0] = firstName_txt.Text;
            }

            // see if lastname is empty
            if (lastName_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Last name.";
                showPanel("userManagement");
            }
            else
            {
                data[1] = lastName_txt.Text;
            }

            // see if usertype is empty
            if (comboBox_userType.Text == "")
            {
                UMError_lbl.Text = "Please enter a User type.";
                showPanel("userManagement");
            }
            else
            {
                data[2] = comboBox_userType.Text;
            }

            // see if email is empty
            if (email_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Email address.";
                showPanel("userManagement");
            }
            else
            {
                data[3] = email_txt.Text;
            }

            // see if phone number is empty
            if (phone_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Phone number.";
                showPanel("userManagement");
            }
            else
            {
                data[4] = phone_txt.Text;
            }

            // see if location/branche is empty
            if (comboBox_location.Text == "")
            {
                UMError_lbl.Text = "Please enter a Location/branche.";
                showPanel("userManagement");
            }
            else
            {
                data[5] = comboBox_location.Text;
            }

            Controller.UserManagementController userManagementController = new Controller.UserManagementController(); 
            userManagementController.addUser(data);

        }
    }
}
