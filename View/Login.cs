using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Model;

namespace View
{
    public partial class Login : Form
    {
        List<User> userList = Model.Model.getAll<User>("Users");

        public Login()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Username != string.Empty)
            {
                textBox_Username.Text = Properties.Settings.Default.Username;
                textBox_Password.Text = Properties.Settings.Default.Password;
            }
        }

        private void button_Login_Click_1(object sender, EventArgs e)
        {
            string warning = "";
            string inputUsername = textBox_Username.Text;
            string inputPassword = textBox_Password.Text;

            if (inputUsername == "" || inputPassword == "")
            {
                warning = "Empty Fields";
            }
            else
            {
                foreach (User u in userList)
                {
                    if (u.Name == inputUsername && u.Password == inputPassword)
                    {
                        warning = "Success";
                        this.Close();
                        //OPEN NIEUW WINDOW
                    }
                    else
                    {
                        warning = "Invalid credentials, please try again.";
                    }
                }

                if (checkBox_Remember.Checked)
                {
                    Properties.Settings.Default.Password = inputPassword;
                    Properties.Settings.Default.Username = inputUsername;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Save();
                }
                label_Warning.Text = warning;
                textBox_Password.Text = "";
            }
        }

        private void linkLabel_Forgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotLogin forget = new ForgotLogin();
            forget.ShowDialog();
            this.Close();
            /*
            
            */
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

