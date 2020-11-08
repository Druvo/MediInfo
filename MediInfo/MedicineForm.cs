using MediInfo.Service.Categorie;
using MediInfo.Service.Companys;
using MediInfo.Service.Consumers;
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



        public MedicineForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _typeService = new TypeService();
            _consumerService = new ConsumerService();
            _companyService = new CompanyService();
            _categorieService = new CategorieService();
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
            MessageBox.Show(cat.ToString(), "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var com = metroComboBox2.SelectedValue;
            MessageBox.Show(com.ToString(), "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var con = metroComboBox4.SelectedValue;
            MessageBox.Show(con.ToString(), "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var type = metroComboBox3.SelectedValue;
            MessageBox.Show(type.ToString(), "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
