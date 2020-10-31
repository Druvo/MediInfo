using MediInfo.Models;
using MediInfo.Service.Types;
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
    public partial class TypeForm : MetroFramework.Forms.MetroForm
    {
        public ITypeService _typeService;
        public TypeForm()
        {
            InitializeComponent();
            _typeService = new TypeService();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _typeService.GetAllTypes())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Code);
                metroListView1.Items.Add(i);
            }
        }
        private void TypeForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string code = metroTextBox2.Text;
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter type name!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter type code!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (is_valid)
            {
                Models.Type type = new Models.Type();
                type.Name = name;
                type.Code = code;
                type.Created_at = DateTime.Now;
                type.Updated_at = DateTime.Now;
                _typeService.Insert(type);
                initList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard Form = new DoctorsDashboard();
            Form.Show();
        }
    }
}
