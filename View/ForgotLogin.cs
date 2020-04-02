using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace View
{
    public partial class ForgotLogin : Form
    {
        public ForgotLogin()
        {
            InitializeComponent();
        }

        private void button_RequestPass_Click(object sender, EventArgs e)
        {
            string requestEmail = textBox_ForgotEmail.Text;
            List<User> users = Model.Model.getAll<User>("Users");
   
            foreach (User u in users)
            {
                if (u.Email == textBox_ForgotEmail.Text)
                {
                    label_ForgotWarning.Text = "We've send you an email with an updated password.";
                    Model.Email.emailPassword(u.Email,u.Name);
                }
                else
                {
                    label_ForgotWarning.Text = "Email not found, please try again.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
