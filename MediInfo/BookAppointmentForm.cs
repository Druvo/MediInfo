using MediInfo.Models;
using MediInfo.Service.Appointments;
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
    public partial class BookAppointmentForm : MetroFramework.Forms.MetroForm
    {
        public IAppointmentService _appointmentService;
        public BookAppointmentForm()
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _appointmentService.GetAllAppointments())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Age);
                i.SubItems.Add(item.Gender);
                i.SubItems.Add(item.Problem);
                i.SubItems.Add(item.Created_at.ToString());
                metroListView1.Items.Add(i);
            }
        }
        private void BookAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var name = metroTextBox1.Text;
            var Age = metroTextBox2.Text;
            var gender = metroTextBox3.Text;
            var problem = metroTextBox4.Text;
            var date = dateTimePicker1.Value;
            Appointment appoi = new Appointment();
            appoi.Name = name;
            appoi.Problem = problem;
            appoi.Age = Age;
            appoi.Gender = gender;
            appoi.Created_at = date;
            _appointmentService.Insert(appoi);
            initList();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
