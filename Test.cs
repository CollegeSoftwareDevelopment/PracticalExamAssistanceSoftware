using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExamAssistanceSoftware
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            //string name = namebox.Text;
            //string roll  = rollbox.Text; ;
            //string branch = branchbox.Text;
        }

        private async void postButton_Click_1(object sender, EventArgs e)
        {

            string baseUrl = "http://" + Properties.Settings.Default.serverUrl + ":" + Properties.Settings.Default.serverPort;

            using (var client = new HttpClient())
            {
                //string baseUrl = "http://localhost:3000";
                string endpoint = "/api/student/add";
                string postData = "{\"name\":\"John\",\"roll\":\"43\",\"branch\":\"CS-A\"}";
                var content = new StringContent(postData, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(baseUrl + endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("POST request successful");
                }
                else
                {
                    MessageBox.Show($"POST request failed: {response.StatusCode}");
                }
            }

        }
    }
}
