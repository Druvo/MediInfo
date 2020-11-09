using MediInfo.Models;
using MediInfo.Service.Categorie;
using MediInfo.Service.Companys;
using MediInfo.Service.Consumers;
using MediInfo.Service.Medicines;
using MediInfo.Service.Types;
using MediInfo.Service.Users;
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
    public partial class MedicineForm : MetroFramework.Forms.MetroForm
    {
        public IUserService _userService;
        public ITypeService _typeService;
        public IConsumerService _consumerService;
        public ICompanyService _companyService;
        public ICategorieService _categorieService;
        public IMedicineService _medicineService;



        public MedicineForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _typeService = new TypeService();
            _consumerService = new ConsumerService();
            _companyService = new CompanyService();
            _categorieService = new CategorieService();
            _medicineService = new MedicineService();

            var cats = _categorieService.GetAllCategories().ToList();
            var com = _companyService.GetAllCompny().ToList();
            var con = _consumerService.GetAllConsumer().ToList();
            var type = _typeService.GetAllTypes().ToList();

            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DataSource = cats;

            metroComboBox2.DisplayMember = "Name";
            metroComboBox2.ValueMember = "Id";
            metroComboBox2.DataSource = com;

            metroComboBox4.DisplayMember = "Name";
            metroComboBox4.ValueMember = "Id";
            metroComboBox4.DataSource = con;

            metroComboBox3.DisplayMember = "Name";
            metroComboBox3.ValueMember = "Id";
            metroComboBox3.DataSource = type;
            initList();
        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _medicineService.GetAllMedi())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Code_name);
                i.SubItems.Add(item.Company.ToString());
                i.SubItems.Add(item.Type.ToString());
                i.SubItems.Add(item.Created_at.ToString());
                metroListView1.Items.Add(i);
            }
        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            var cat = metroComboBox1.SelectedValue;
            var com = metroComboBox2.SelectedValue;
            var con = metroComboBox4.SelectedValue;
            var type = metroComboBox3.SelectedValue;
            var name = metroTextBox1.Text;
            var code = metroTextBox2.Text;
            var price = metroTextBox3.Text;
            var qnt = metroTextBox4.Text;
            Medicine medicine = new Medicine();
            medicine.Name = name;
            medicine.Code_name = code;
            medicine.Company = Convert.ToInt32(com);
            medicine.Consumer = Convert.ToInt32(con);
            medicine.Created_at = DateTime.Now;
            medicine.Updated_at = DateTime.Now;
            medicine.Image = 1;
            medicine.Ingredient = "";
            medicine.Tags = "";
            medicine.Type = Convert.ToInt32(type);
            medicine.Alternative = Convert.ToInt32(1);
            //medicine.Quantity = Convert.ToInt32(qnt);
            //medicine.Price = Convert.ToInt32(price);
            _medicineService.Insert(medicine);
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

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
