﻿using Csharp_Login_And_Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediInfo
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm login = new LoginForm();
            //login.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard login = new DoctorsDashboard();
            login.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookAppointmentForm login = new BookAppointmentForm();
            login.Show();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            posForm pos = new posForm();
            pos.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm pos = new AboutForm();
            pos.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm pos = new CustomerForm();
            pos.Show();
        }
    }
}
