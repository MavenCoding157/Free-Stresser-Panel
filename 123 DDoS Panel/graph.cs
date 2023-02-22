using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace _123_DDoS_Panel
{
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();
        }

        private void graph_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://horizon.netscout.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
