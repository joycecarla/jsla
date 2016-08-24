using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace juan_sumulong_learning_app
{
    public partial class Form1 : Form
    {
        WebServer s = new WebServer("http://localhost/");

        public Form1()
        {
            InitializeComponent();
            s.DownloadProgressChanged += S_DownloadProgressChanged;
        }

        private void S_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = (e.BytesReceived / 1048576d).ToString() + "MB of " + (e.TotalBytesToReceive / 1048576d) + "MB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.DownloadFile("ITS/music.mkv", "C:/Users/TweakBox/Desktop/music.mkv");
        }
    }
}
