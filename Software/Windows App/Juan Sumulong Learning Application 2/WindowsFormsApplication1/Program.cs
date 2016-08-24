using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace juan_sumulong_learning_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new StudentInformation(new Database("jsla", "localhost")));
            //Application.Run(new Form1());
        }
    }
}
