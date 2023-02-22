using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123_DDoS_Panel
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok bye");
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var username = System.Environment.GetEnvironmentVariable("USERNAME");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\PC\\Desktop\\123 DDoS Panel\\123 DDoS Panel\\123 DDoS Panel\\bin\\Debug\\net6.0-windows\\Freddie Dredd - Limbo (Lyrics).wav");
            player.Play();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var username = System.Environment.GetEnvironmentVariable("USERNAME");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\PC\\Desktop\\123 DDoS Panel\\123 DDoS Panel\\123 DDoS Panel\\bin\\Debug\\net6.0-windows\\Freddie Dredd - Limbo (Lyrics).wav");
            player.Stop();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(72, 68, 68);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
