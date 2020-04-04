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
using MongoDB.Driver;
using MongoDB.Bson;

namespace View
{
    public partial class Login : Form
    {
        //Initializing and setting user data in app settings if remember was checked on previous login
        public Login()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Username != string.Empty)
            {
                textBox_Username.Text = Properties.Settings.Default.Username;
                textBox_Password.Text = Properties.Settings.Default.Password;
            }
        }

        //Handling user input and checking for valid fields in database for confirmation
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
                FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("Name", inputUsername);
                User user = new User().SelectWhere<User>(filter);
                if(user == null)
                {
                    warning = "User not found.";
                    textBox_Username.Text = "";
                }
                else
                {
                    if(user.password == inputPassword)
                        warning = "Success.";
                    else
                        warning = "Password incorrect.";
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
            }
            textBox_Password.Text = "";
            label_Warning.Text = warning;
        }

        //Enabling visability for forgotLogin panel
        private void linkLabel_Forgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_forgot.Show();
        }

        //Closing the application
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Checking email input, getting database information and calling password creation method
        private void button_RequestPass_Click(object sender, EventArgs e)
        {
            string requestEmail = textBox_ForgotEmail.Text;
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("Email", requestEmail);
            User user = new User().SelectWhere<User>(filter);
            if (user == null)
            {
                label_Warning.Text = "Email not found, please try again.";
            }
            else
            {
                panel_forgot.Hide();
                string newPass = CreatePassword(10);
                label_Warning.Text = "We've send you an email with an updated password.";
                Model.Email.emailPassword(user.email, user.name, newPass);
                panel_forgot.Hide();
            }
        }

        //Creating a new password for user
        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //Hides forgotLogin panel
        private void button_hide_Click(object sender, EventArgs e)
        {
            panel_forgot.Hide();
        }
    }
}

