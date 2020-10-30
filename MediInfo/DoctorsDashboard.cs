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
    }
}
