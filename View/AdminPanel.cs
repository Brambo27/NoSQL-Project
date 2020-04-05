using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AdminPanel : Form
    {
        string selectedBackupLocation;
        string selectedBackupFile;
        string[] selectedBackupFiles;
        List<CheckBox> checkboxes = new List<CheckBox>();
        public AdminPanel()
        {
            InitializeComponent();

            Point checkboxLocation = new Point(220, 35);
            foreach (string collectionName in Model.Model.getAllCollectionNames())
            {
                CheckBox checkBox = new CheckBox()
                {
                    Text = collectionName,
                    Location = checkboxLocation,
                    Height = 15,
                    Width = 100
                };

                this.Controls.Add(checkBox);
                checkboxes.Add(checkBox);
                
                checkboxLocation.Y += 15;
            }

        }

        private void StartBackup_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    Model.Model.BackupDocuments(selectedBackupLocation, checkbox.Text);
                }
            }


        }

        private void backupLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedBackupLocation = fbd.SelectedPath;
                StartBackup.Text = "Make backup to: " + selectedBackupLocation;
            }
        }

        private void ReturnBackupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Model.InsertFromBackup(selectedBackupFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            } 
        }

        private void SelectBackupFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "Text Files (*.txt)|*.txt";
                choofdlog.FilterIndex = 1;
                choofdlog.Multiselect = false;

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    selectedBackupFile = choofdlog.FileName;
                    //selectedBackupFiles = choofdlog.FileNames; //used when Multiselect = true   
                    ReturnBackupBtn.Text = "Upload backup to Database from: " + selectedBackupFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }


        }
    }
}
