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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            progressValues();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressValues()
        {
            //Daadwerkelijke waarden missen nog
            progress_deadline.Value = 2;
            progress_unresolved.Value = 5;

        }
    }
}
