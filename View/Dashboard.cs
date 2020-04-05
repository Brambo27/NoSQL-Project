using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Model;

namespace View
{
    public partial class Dashboard : Form
    {
        User currentUser;
        public Dashboard(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser.userType == User.UserType.Admin)
            {
                openBackupToolBtn.Show();
            }
            //var deleteFilter = Builders<BsonDocument>.Filter.Eq("IncidentID", "1");
            //Model.Model.deleteDocument("Incidents", deleteFilter);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            showPanel("dashboard");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void progress_deadline_Click(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private void showPanel(string panelName)
        {
            dashboard_panel.Hide();
            incidentManagement_panel.Hide();
            createUser_panel.Hide();
            userManagement_panel.Hide();
            createIncident_panel.Hide();

            switch (panelName)
            {
                case "dashboard":
                    progressValues();
                    dashboard_panel.Show();
                    break;
                case "incidentManagement":
                    dt2 = getTableIncidents();
                    dataGridView_incidentManagement.DataSource = dt2;
                    incidentManagement_panel.Show();
                    break;
                case "userManagement":
                    dt = getTable();
                    dataGridView_userManagement.DataSource = dt;
                    userManagement_panel.Show();
                    break;
                case "createUser":
                    createUser_panel.Show();
                    break;
                case "createIncident":
                    createIncident_panel.Show();
                    break;
            }
        }

        private void menuDashboard_btn_Click(object sender, EventArgs e)
        {
            showPanel("dashboard");
        }

        private void menuIncidentManagement_btn_Click(object sender, EventArgs e)
        {
            showPanel("incidentManagement");
        }

        private void menuUsersManagement_btn_Click(object sender, EventArgs e)
        {
            showPanel("userManagement");
        }

        static DataTable getTableIncidents()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("User", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Status", typeof(string));

            List<Incident> incidents = Model.Model.getAll<Incident>("Incidents");

            foreach (Incident i in incidents)
            {
                table.Rows.Add(i.Id, i.subject, i.reportedBy, i.createdAt, i.deadline);
            }

            return table;
        }

        static DataTable getTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("# Tickets", typeof(int));

            List<User> users = Model.Model.getAll<User>("Users");

            char[] c = { ' ' };
            string[] nameArray;
            int aantalTicket;

            foreach (User u in users)
            {
                string first = u.firstName;
                string last = u.lastName;

                if (u.name != null)
                {
                    nameArray = u.name.Split(c, 2);
                    first = nameArray[0];
                    last = nameArray[1];
                }
                var selectFilter = Builders<BsonDocument>.Filter.Eq("reportedBy", first + " " + last);
                List<Incident> tickets = Model.Model.selectAllWhere<Incident>("Incidents", selectFilter);
                aantalTicket = tickets.Count;
                table.Rows.Add(u.userId, u.email, first, last, aantalTicket);
            }

            return table;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            firstName_txt.ReadOnly = true;
            lastName_txt.ReadOnly = true;
            email_txt.ReadOnly = true;
            phoneNumber_txt.ReadOnly = true;
            comboBox_userType.Enabled = true;
            comboBox_location.Enabled = true;

            firstName_txt.Text = "";
            lastName_txt.Text = "";
            email_txt.Text = "";
            phoneNumber_txt.Text = "";
            userId_txt.Text = "";
            addUser_lbl.Text = "Create New User";

            sendPW_lbl.Show();
            checkBox_sendPW.Show();
            createUserConfirm_btn.Show();
            editUserConfirm_btn.Hide();

            showPanel("createUser");
        }

        private void userFilter_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("email like '%{0}%'", userFilter_txt.Text);
                dataGridView_userManagement.DataSource = dv.ToTable();
            }
        }

        private void comboBox_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createUserCancel_btn_Click(object sender, EventArgs e)
        {
            showPanel("userManagement");
        }

        private void createUserConfirm_btn_Click(object sender, EventArgs e)
        {
            List<string> user = new List<string>();
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
            else if (phoneNumber_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Phone number.";
            }
            else if (comboBox_location.Text == "")
            {
                UMError_lbl.Text = "Please enter a Location/branche.";
            }

            if (UMError_lbl.Text == "")
            {
                user.Add(firstName_txt.Text);
                user.Add(lastName_txt.Text);
                user.Add(comboBox_userType.Text);
                user.Add(email_txt.Text);
                user.Add(phoneNumber_txt.Text);
                user.Add(comboBox_location.Text);

                addUser(user);
                showPanel("userManagement");
            }
            else
            {
                showPanel("addUser");
            }
        }

        private void addUser(List<string> data)
        {
            List<User> users = Model.Model.getAll<User>("Users");
            int userID = users.Count + 1;
            User.UserType userType;
            if(data[2] == "Employee")
            {
                userType = User.UserType.Employee;
            } else
            {
                userType = User.UserType.Admin;
            }

            var user1 = new BsonDocument
            {
                {"userId", userID.ToString() },
                {"firstName", data[0] },
                {"lastName", data[1] },
                {"name", data[0] + " " + data[1] },
                {"password", Membership.GeneratePassword(12, 1) },
                {"userType", userType },
                {"email", data[3] },
                {"phoneNumber", data[4] },
                {"location", data[5] }
            };

            Model.Model.insertIntoCollection("Users", user1);
        }

        private void addIncident(List<string> data)
        {
            List<Incident> incidents = Model.Model.getAll<Incident>("Incidents");
            int incidentID = incidents.Count + 1;
            var incident1 = new BsonDocument
            {
                {"createdAt", data[0] },
                {"Subject", data[1] },
                {"Type", data[2] },
                {"ReportedBy", data[3] },
                {"Priority", data[4] },
                {"Deadline", data[5] },
                {"Description", data[6] },
                {"IncidentID", incidentID.ToString() },
            };

            Model.Model.insertIntoCollection("Incidents", incident1);
        }

        private void incidentManagement_lbl_Click(object sender, EventArgs e)
        {

        }


        private void addNewIncidentBtn_Click(object sender, EventArgs e)
        {
            showPanel("createIncident");
        }

        private void cancelIncidentCreateBtn_Click(object sender, EventArgs e)
        {
            createIncident_panel.Hide();
            incidentManagement_panel.Show();
        }

        private void addIncidentBtn_Click(object sender, EventArgs e)
        {
            List<string> incident = new List<string>();
            IMError_lbl.Text = "";

            // error checks
            if (selectDataComboBox.Text == "")
            {
                IMError_lbl.Text = "Please select a date.";
            }
            else if (incidentSubjectTextBox.Text == "")
            {
                IMError_lbl.Text = "Please enter an incident subject.";
            }
            else if (selectTypeComboBox.Text == "")
            {
                IMError_lbl.Text = "Please select a type.";
            }
            else if (reportedByComboBox.Text == "")
            {
                IMError_lbl.Text = "Please select a user.";
            }
            else if (priorityComboBox.Text == "")
            {
                IMError_lbl.Text = "Please select a priority level.";
            }
            else if (followUpComboBox.Text == "")
            {
                IMError_lbl.Text = "Please select a deadline.";
            }
            else if (descriptionTextBox.Text == "")
            {
                IMError_lbl.Text = "Please enter a description.";
            }

            if (IMError_lbl.Text == "")
            {
                incident.Add(selectDataComboBox.Text);
                incident.Add(incidentSubjectTextBox.Text);
                incident.Add(selectTypeComboBox.Text);
                incident.Add(reportedByComboBox.Text);
                incident.Add(priorityComboBox.Text);
                incident.Add(followUpComboBox.Text);
                incident.Add(descriptionTextBox.Text);

                addIncident(incident);
                dt2 = getTableIncidents();
                showPanel("incidentManagement");
            }
            else
            {
                showPanel("createIncident");
            }
        }

        private void button_LowPrior_Click(object sender, EventArgs e)
        {
            PriorityHandler("Low");
        }

        private void button_MedPrior_Click(object sender, EventArgs e)
        {
            PriorityHandler("Medium");
        }

        private void button_HighPrior_Click(object sender, EventArgs e)
        {
            PriorityHandler("High");
        }

        List<Incident> incidents = Incident.getAll();

        private void PriorityHandler(string priority)
        {
            int amount = 0;
            
            label_Prior.Text = priority+" priority Incidents";
            foreach (Incident i in incidents)
            {
                if (i.priority == (Incident.IncidentPriority)Enum.Parse(typeof(Incident.IncidentPriority), priority))
                {
                    amount++;
                }
            }
            progress_priority.Value = amount;
            progress_priority.Text = amount.ToString()+"/"+incidents.Count;
        }

        private void progressValues()
        {
            List<Incident> incidents = Incident.getAll();
            int incidentsPastDeadline = 0;
            int incidentsUnresolved = 0;
            foreach (Incident i in incidents)
            {
                if (i.deadline > DateTime.Now)
                {
                    incidentsPastDeadline++;
                }
                if(i.status == (Incident.IncidentStatus)Enum.Parse(typeof(Incident.IncidentStatus), "Unresolved"))
                {
                    incidentsUnresolved++;
                }
            }
            progress_deadline.Maximum = incidents.Count;
            progress_unresolved.Maximum = incidents.Count;
            progress_priority.Maximum = incidents.Count;

            progress_deadline.Text = incidentsPastDeadline + "/" + incidents.Count;
            progress_unresolved.Text = incidentsUnresolved + "/" + incidents.Count;



            progress_deadline.Value = incidentsPastDeadline;
            progress_unresolved.Value = incidentsUnresolved;

        }

        private void viewUser_btn_Click(object sender, EventArgs e)
        {
            
            firstName_txt.ReadOnly = true;
            lastName_txt.ReadOnly = true;
            email_txt.ReadOnly = true;
            phoneNumber_txt.ReadOnly = true;
            comboBox_userType.Enabled = true;
            comboBox_location.Enabled = true;

            User db = new User();
            DataGridViewRow selected = dataGridView_userManagement.SelectedRows[0];
            string userid = selected.Cells[0].Value.ToString();
            User user = db.getById("userId", userid, "Users");
            userId_txt.Text = user.userId;
            firstName_txt.Text = user.firstName;
            lastName_txt.Text = user.lastName;
            comboBox_userType.Text = user.userType.ToString();
            email_txt.Text = user.email;
            phoneNumber_txt.Text = user.phoneNumber;
            comboBox_location.Text = user.location;
            addUser_lbl.Text = "View User";

            sendPW_lbl.Hide();
            checkBox_sendPW.Hide();
            createUserConfirm_btn.Hide();

            showPanel("createUser");
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            User db = new User();
            DataGridViewRow selected = dataGridView_userManagement.SelectedRows[0];
            string userid = selected.Cells[0].Value.ToString();
            User user = db.getById("userId", userid, "Users");
            userId_txt.Text = user.userId;
            firstName_txt.Text = user.firstName;
            lastName_txt.Text = user.lastName;
            comboBox_userType.Text = user.userType.ToString();
            email_txt.Text = user.email;
            phoneNumber_txt.Text = user.phoneNumber;
            comboBox_location.Text = user.location;
            addUser_lbl.Text = "Edit User";

            sendPW_lbl.Hide();
            checkBox_sendPW.Hide();
            createUserConfirm_btn.Hide();
            editUserConfirm_btn.Show();

            showPanel("createUser");
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            User db = new User();
            DataGridViewRow selected = dataGridView_userManagement.SelectedRows[0];
            string userid = selected.Cells[0].Value.ToString();
            User user = db.getById("userId", userid, "Users");
            string message = "Are you sure you want to delete " + user.name + "?";
            string caption = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var selectFilter = Builders<BsonDocument>.Filter.Eq("reportedBy", user.name);
                List<Incident> tickets = Model.Model.selectAllWhere<Incident>("Incidents", selectFilter);
                foreach(Incident ticket in tickets)
                {
                    if (ticket.deadline <= DateTime.Now)
                    {
                        message = "This user has an unresolved incident. The incident will be deleted if you continue.";
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            var deleteFilter = Builders<BsonDocument>.Filter.Eq("subject", ticket.subject);
                            Model.Model.deleteDocument("Incidents", deleteFilter);
                        }
                        break;
                    }
                }
                var deleteFilter2 = Builders<BsonDocument>.Filter.Eq("userId", userid);
                Model.Model.deleteDocument("Users", deleteFilter2);
                showPanel("userManagement");
            }
        }

        private void editUserConfirm_btn_Click(object sender, EventArgs e)
        {
            List<string> user = new List<string>();
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
            else if (phoneNumber_txt.Text == "")
            {
                UMError_lbl.Text = "Please enter a Phone number.";
            }
            else if (comboBox_location.Text == "")
            {
                UMError_lbl.Text = "Please enter a Location/branche.";
            }

            if (UMError_lbl.Text == "")
            {
                user.Add(firstName_txt.Text);
                user.Add(lastName_txt.Text);
                user.Add(comboBox_userType.Text);
                user.Add(email_txt.Text);
                user.Add(phoneNumber_txt.Text);
                user.Add(comboBox_location.Text);

                editUser(user, userId_txt.Text);
                showPanel("userManagement");
            }
            else
            {
                showPanel("addUser");
            }
        }

        private void editUser(List<string> data, string userId)
        {
            User db = new User();
            User user = db.getById("userId", userId);
            User.UserType userType;
            if (data[2] == "Employee")
            {
                userType = User.UserType.Employee;
            }
            else
            {
                userType = User.UserType.Admin;
            }

            var user1 = new BsonDocument
            {
                {"userId", userId},
                {"firstName", data[0] },
                {"lastName", data[1] },
                {"name", data[0] + " " + data[1] },
                {"password", Membership.GeneratePassword(12, 1) },
                {"userType", userType },
                {"email", data[3] },
                {"phoneNumber", data[4] },
                {"location", data[5] }
            };

            var update = Builders<BsonDocument>.Update.Set("userId", userId);

            Model.Model.updateDocument("Users", user1, update);

            update = Builders<BsonDocument>.Update.Set("reportedBy", user.name);
            var incident = new BsonDocument { { "reportedBy", data[0] + " " + data[1] } };      
        }

        private void openBackupToolBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new AdminPanel());
        }
    }
}
