using MediInfo.Models;
using MediInfo.Service.Consumers;
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
    public partial class ConsumerForm : MetroFramework.Forms.MetroForm
    {
        public IConsumerService _consumerService;
        public ConsumerForm()
        {
            InitializeComponent();
            _consumerService = new ConsumerService();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _consumerService.GetAllConsumer())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Code);
                metroListView1.Items.Add(i);
            }
        }
        private void ConsumerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard Form = new DoctorsDashboard();
            Form.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string code = metroTextBox2.Text;
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter consumer name!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter consumer code!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (is_valid)
            {
                Consumer cat = new Consumer();
                cat.Name = name;
                cat.Code = code;
                cat.Created_at = DateTime.Now;
                cat.Updated_at = DateTime.Now;
                _consumerService.Insert(cat);
                initList();
            }
        }
    }
}
