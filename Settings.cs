using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExamAssistanceSoftware
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void loadDetails()
        {
            serverUrlBox.Text = Properties.Settings.Default.serverUrl;
            serverPortBox.Text = Properties.Settings.Default.serverPort;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.serverUrl = serverUrlBox.Text;
            Properties.Settings.Default.serverPort = serverPortBox.Text;

            Properties.Settings.Default.Save();
        }
    }
}
