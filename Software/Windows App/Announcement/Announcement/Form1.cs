using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Announcement
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < imageList1.Images.Count - 1)
                i++;
            else
                i = 0;

            slideshow(i);
        }
        private void slideshow(int index)
        {
            pictureBox1.Image = imageList1.Images[index];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slideshow(--i);
            timer1.Stop();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slideshow(++i);
            timer1.Stop();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("");
        }
    }
}
