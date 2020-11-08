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
    public partial class DoctorsDashboard : MetroFramework.Forms.MetroForm
    {
        public DoctorsDashboard()
        {
            InitializeComponent();
        }

        private void DoctorsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm Form = new CategoriesForm();
            Form.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyForm Form = new CompanyForm();
            Form.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeForm Form = new TypeForm();
            Form.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsumerForm Form = new ConsumerForm();
            Form.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm Form = new MedicineForm();
            Form.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }
    }
}
