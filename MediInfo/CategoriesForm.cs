using MediInfo.Models;
using MediInfo.Service.Categorie;
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
    public partial class CategoriesForm : MetroFramework.Forms.MetroForm
    {
        public ICategorieService _categorieService;
        public CategoriesForm()
        {
            InitializeComponent();
            _categorieService = new CategorieService();
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _categorieService.GetAllCategories())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Pic);
                metroListView1.Items.Add(i);
            }
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = metroTextBox1.Text;
            string picture = metroTextBox2.Text;
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter category name!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(picture))
            {
                MessageBox.Show("Please enter category picture!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (is_valid)
            {
                Categories cat = new Categories();
                cat.Name = name;
                cat.Pic = picture;
                _categorieService.Insert(cat);
                initList();
            }
            

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsDashboard Form = new DoctorsDashboard();
            Form.Show();
        }
    }
}
