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
    public partial class CustomerForm : MetroFramework.Forms.MetroForm
    {
        public ICustemerServices _CustomersService;
        public CustomerForm()
        {
            InitializeComponent();
            _CustomersService = new CustemerServices();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _CustomersService.GetAllCustomers())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Mobile);
                i.SubItems.Add(item.Adress);
                metroListView1.Items.Add(i);
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string no = metroTextBox2.Text;
            string add = metroTextBox3.Text;
            Customers cat = new Customers();
            cat.Name = name;
            cat.Mobile = no;
            cat.Adress = add;
            _CustomersService.Insert(cat);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }
    }
}
