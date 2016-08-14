﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace juan_sumulong_learning_app
{
    public partial class frm_login : Form
    {
        private MySqlCommand command;
        private MySqlDataReader reader;

        private UserAccount _userAccount;

        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_userID_Enter(object sender, EventArgs e)
        {
            if (txtBox_userID.Text == "User ID")
            {
                txtBox_userID.Text = "";
            }
            

        }

        private void txtBox_userID_Leave(object sender, EventArgs e)
        {
            if (txtBox_userID.Text == "")
            {
                txtBox_userID.Text = "User ID";
            }
            
        }

        private void txtBox_password_Enter(object sender, EventArgs e)
        {
            txtBox_password.Text = "";
            txtBox_password.PasswordChar = '•';
        }

        private void txtBox_password_Leave(object sender, EventArgs e)
        {
            if (txtBox_password.Text == "")
            {
                txtBox_password.Text = "Password";
                txtBox_password.PasswordChar = '\0' ;
            }
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (Database.IsOpen) Database.Close();

            Database.Open();

            try
            {
               
                string query = String.Format("SELECT userID, accType FROM tbl_accounts WHERE userID='{0}' AND password='{1}';", txtBox_userID.Text, txtBox_password.Text);
                command = new MySqlCommand(query, Database.Connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        _userAccount.ID = reader[0].ToString();
                        _userAccount.Type = reader[1].ToString();
                        MessageBox.Show(_userAccount.ID + " and " + _userAccount.Type);
                    }
                else
                    MessageBox.Show("User doesn't exist.");

                    
                MessageBox.Show("Welcome!");


                
            }
            catch(Exception ex)
            {

 
            }


        }

    }
}
