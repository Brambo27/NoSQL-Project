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

        static int attempts = 3;
        List<dynamic> userList = Model.Model.getAll("Users");

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
                        break;
                    }
                    else
                    {
                        warning = userList.Count + "";
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

                attempts--;
               


                if (attempts == 0)
                {
                    textBox_Password.Enabled = false;
                    textBox_Username.Enabled = false;
                    warning = "No attempts left";
                }
                label_Warning.Text = warning;
                textBox_Password.Text = "";
                textBox_Username.Text = "";
            }
        }

        private void linkLabel_Forgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ForgotLogin forget = new ForgotLogin();
            forget.ShowDialog();
            this.Close();
            /*
            var fromAddress = new MailAddress("testing69php@gmail.com", "Boe een hacker");
            var toAddress = new MailAddress("kjellpepp2000@gmail.com", "Hans Worst");
            const string fromPassword = "phpisheelleuk12";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            */
        }
    }
}

