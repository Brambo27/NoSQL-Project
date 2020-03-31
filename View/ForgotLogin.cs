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
            List<dynamic> users = Model.Model.getAll("Users");
   
            foreach (User c in users)
            {
                if(c.Email == textBox_ForgotEmail.Text)
                {
                    label_ForgotWarning.Text = "email gevonden";
                    Model.Email.emailPassword();
                }
                else
                {
                    label_ForgotWarning.Text = "niet gevonden";
                }
            }


        }
    }
}
