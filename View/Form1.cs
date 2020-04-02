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
using Model;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controller.UserManagementController userManagementController = new Controller.UserManagementController();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        DataTable dt = getTable();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            showPanel("dashboard");
            
            dataGridView_users.DataSource = dt;
        }

        private void showPanel(string panelName)
        {
            panel_addUser.Hide();
            panel_userManagement.Hide();

            switch (panelName)
            {
                case "dashboard":;
                    break;
                case "incidentManagement":;
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
            List<dynamic> user = new List<dynamic>();
            UMError_lbl.Text = "";

            // error checks
            if (firstName_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a First name.";
            } 
            else if (lastName_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Last name.";
            }
            else if (comboBox_userType.Text == "")
            {
                UMError_lbl.Text = "Please enter a User type.";
            }
            else if (email_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Email address.";
            }
            else if (phone_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Phone number.";
            }
            else if (comboBox_location.Text == "")
            {
                UMError_lbl.Text = "Please enter a Location/branche.";
            }

            if(UMError_lbl.Text == "")
            {
                user.Add(firstName_txt.Text);
                user.Add(lastName_txt.Text);
                user.Add(comboBox_userType.Text);
                user.Add(email_txt.Text);
                user.Add(phone_txt.Text);
                user.Add(comboBox_location.Text);
                
                userManagementController.addUser(user);
                dt = getTable();
                showPanel("userManagement");
            } else
            {
                showPanel("addUser");
            }
        }

        private void filter_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("email like '%{0}%'", filter_txt.Text);
                dataGridView_users.DataSource = dv.ToTable();
            }
        }

        static DataTable getTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("# Tickets", typeof(string));

            List<User> users = Model.Model.getAll<User>("Users");

            char[] c = { ' ' };
            string[] nameArray;

            foreach (User u in users)
            {
                string first = u.FirstName;
                string last = u.LastName;

                if (u.Name != null)
                {
                    nameArray = u.Name.Split(c, 2);
                    first = nameArray[0];
                    last = nameArray[1];
                }
                table.Rows.Add(u.UserId, u.Email, first, last, u.Tickets);
            }

            return table;
        }

        private void menuDashboard_btn_Click(object sender, EventArgs e)
        {
            showPanel("dashboard");
        }

        private void menuIncident_btn_Click(object sender, EventArgs e)
        {
            showPanel("incidentManagement");
        }

        private void menuUser_btn_Click(object sender, EventArgs e)
        {
            showPanel("userManagement");
        }
    }
}
