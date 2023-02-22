using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123_DDoS_Panel
{
    public partial class Moretools : Form
    {
        public Moretools()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(textBox1.Text, 1000);

            if (reply.Status.ToString() == "Success")
            {
                label2.Text = "Active";
                label2.ForeColor = Color.LimeGreen;
            }
            else
            {
                label2.Text = "IP Down";
                label2.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MachineName1 = Environment.UserName;
            MessageBox.Show(System.Environment.UserName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassGenerator(6);
            }
            else if (checkBox2.Checked)
            {
                PassGenerator(10);
            }
            else if (checkBox3.Checked)
            {
                PassGenerator(12);
            }
        }
        public void PassGenerator(int len)
        {
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJCLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            textBox2.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getMyIPAddress());
        }
        private string getMyIPAddress()
        {
            String Address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                Address = stream.ReadToEnd();
            }
            int first = Address.IndexOf("Address: ") + 9;
            int last = Address.IndexOf("</body>");
            Address = Address.Substring(first, last - first);
            return Address;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discord: George Batholimew Hograth#0869\nEmail: Pringle687@proton.me", "Contact Me", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new graph().Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Tools menu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string geoip = wc.DownloadString("http://ip-api.com/json/" + textBox5.Text);
            richTextBox1.Text = geoip;
        }
    }
}
