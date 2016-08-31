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
    public partial class StudentInfomation : Form
    {
        public StudentInfomation()
        {
            InitializeComponent();
        }

        private void StudentInfomation_Load(object sender, EventArgs e)
        {

        }

      
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCancel.Text = "Clear";
        }
    }
}
