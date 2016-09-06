using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_JSLA
{
    public partial class picturebutton : UserControl
    {
        public Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Descripiton
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public picturebutton()
        {
            InitializeComponent();
        }
    }
}
