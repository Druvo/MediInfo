﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        
        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //DB db = new DB();

            //String username = textBoxUsername.Text;
            //String password = textBoxPassword.Text;

            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            //command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            //adapter.SelectCommand = command;

            //adapter.Fill(table);

            //// check if the user exists or not
            //if (table.Rows.Count > 0)
            //{
            //    this.Hide();
            //    MainForm mainform = new MainForm();
            //    mainform.Show();
            //}
            //else
            //{
            //    if(username.Trim().Equals(""))
            //    {
            //        MessageBox.Show("Enter Your Username To Login","Empty Username",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //    else if (password.Trim().Equals(""))
            //    {
            //        MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
