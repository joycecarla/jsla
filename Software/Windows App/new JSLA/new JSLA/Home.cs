using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_JSLA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            StudentInfomation studinfo = new StudentInfomation();
            studinfo.TopLevel = false;
            studinfo.FormBorderStyle = FormBorderStyle.None;
            pnl.Controls.Clear();
            pnl.Controls.Add(studinfo);
            studinfo.Visible = true;

        }

      
    }
}
