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
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("User", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
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
            table.Columns.Add("# Tickets", typeof(string));

            List<User> users = Model.Model.getAll<User>("Users");

            char[] c = { ' ' };
            string[] nameArray;

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
                table.Rows.Add(u.userId, u.email, first, last, u.tickets);
            }

            return table;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
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
                dt = getTable();
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
            var selectFilter = Builders<BsonDocument>.Filter.Eq("Name", data[0]);
            List<dynamic> tickets = Model.Model.selectAllWhere<dynamic>("Incidents", selectFilter);
            int userID = users.Count + 1;
            var user1 = new BsonDocument
            {
                {"UserId", userID.ToString() },
                {"FirstName", data[0] },
                {"LastName", data[1] },
                {"Name", data[0] + " " + data[1] },
                {"Password", Membership.GeneratePassword(12, 1) },
                {"UserType", data[2] },
                {"Email", data[3] },
                {"PhoneNumber", data[4] },
                {"Location", data[5] },
                {"Tickets", tickets.Count.ToString() }
            };

            Model.Model.insertIntoCollection("Users", user1);
        }

        private void addIncident(List<string> data)
        {
            List<Incident> incidents = Model.Model.getAll<Incident>("Incidents");
            Incident incident1 = new Incident
            {
                createdAt = dateReportedDateTimePicker.Value,
                subject = data[1],
                type = data[2],
                reportedBy = data[3],




                //{"createdAt", data[0] },
                //{"subject", data[1] },
                //{"type", data[2] },
                //{"reportedBy", data[3] },
                //{"priority", data[4] },
                //{"deadline", data[5] },
                //{"description", data[6] },
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
            if (dateReportedDateTimePicker.Text == "")
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
                incident.Add(dateReportedDateTimePicker.Text);
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
    }
}
