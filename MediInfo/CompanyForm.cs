using MediInfo.Models;
using MediInfo.Service.Companys;
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
    public partial class CompanyForm : MetroFramework.Forms.MetroForm
    {
        public ICompanyService _companyService;

        public CompanyForm()
        {
            InitializeComponent();
            _companyService = new CompanyService();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _companyService.GetAllCompny())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Location);
                metroListView1.Items.Add(i);
            }
        }
        private void CompanyForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string location = metroTextBox2.Text;
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter company name!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please enter company location!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (is_valid)
            {
                Company cat = new Company();
                cat.Name = name;
                cat.Location = location;
                cat.Created_at = DateTime.Now;
                cat.Updated_at = DateTime.Now;
                _companyService.Insert(cat);
                initList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard Form = new DoctorsDashboard();
            Form.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard Form = new DoctorsDashboard();
            Form.Show();
        }
    }
}
