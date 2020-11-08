using MediInfo.Service.Medicines;
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
    public partial class POS : MetroFramework.Forms.MetroForm
    {
        public IMedicineService _medicineService;

        public POS()
        {
            InitializeComponent();
            _medicineService = new MedicineService();

            initList();

        }

        private void POS_Load(object sender, EventArgs e)
        {

        }
        public void initList()
        {
            metroListView1.Items.Clear();
            foreach (var item in _medicineService.GetAllMedi())
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.Name);
                i.SubItems.Add(item.Code_name);
                i.SubItems.Add(item.Price.ToString());
                i.SubItems.Add(item.Quantity.ToString());
                metroListView1.Items.Add(i);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void dtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
