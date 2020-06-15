using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class AdminPanel : Form
    {
        private readonly List<CheckBox> _checkboxes = new List<CheckBox>();
        private string _selectedBackupFile;
        private string[] _selectedBackupFiles;
        private string _selectedBackupLocation;
        private readonly Point _checkboxLocation = new Point(220, 35);

        public AdminPanel()
        {
            InitializeComponent();
            CreateCheckBoxesForEachCollection(_checkboxLocation);
        }

        private void CreateCheckBoxesForEachCollection(Point checkboxLocation)
        {
            foreach (var checkBox in Model.Model.getAllCollectionNames().Select(collectionName => new CheckBox
            {
                Text = collectionName,
                Location = checkboxLocation,
                Height = 15,
                Width = 100
            }))
            {
                Controls.Add(checkBox);
                _checkboxes.Add(checkBox);

                checkboxLocation.Y += 15;
            }
        }

        private void StartBackup_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var checkbox in _checkboxes.Where(checkbox => checkbox.Checked))
                    Model.Model.BackupDocuments(_selectedBackupLocation, checkbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        // MessageBox.Show("Please select a collection to backup", "Error", MessageBoxButtons.OK);

        private void backupLocationButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _selectedBackupLocation = fbd.SelectedPath;
                StartBackup.Text = "Make backup to: " + _selectedBackupLocation;
            }
        }

        private void ReturnBackupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Model.InsertFromBackup(_selectedBackupFile);
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
                var fileDialog = new OpenFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt", 
                    FilterIndex = 1, 
                    Multiselect = false
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedBackupFile = fileDialog.FileName;
                    //selectedBackupFiles = fileDialog.FileNames; //used when Multiselect = true   
                    ReturnBackupBtn.Text = "Upload backup to Database from: " + _selectedBackupFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}