using MediInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            //this.ActiveControl = label1;
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.White;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            //// add a new user

            //DB db = new DB();
            //MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            //command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            //command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            //command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //// open the connection
            //db.openConnection();

            //// check if the textboxes contains the default values 
            //if (!checkTextBoxesValues())
            //{
            //    // check if the password equal the confirm password
            //    if(textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
            //    {
            //        // check if this username already exists
            //        if (checkUsername())
            //        {
            //            MessageBox.Show("This Username Already Exists, Select A Different One","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            // execute the query
            //            if (command.ExecuteNonQuery() == 1)
            //            {
            //                MessageBox.Show("Your Account Has Been Created","Account Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("ERROR");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong Confirmation Password","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            //    }
                
            //}
            //else
            //{
            //    MessageBox.Show("Enter Your Informations First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            //}
            
            

            //// close the connection
            //db.closeConnection();

        }

        
        // check if the username already exists
        public Boolean checkUsername()
        {
            //DB db = new DB();

            //String username = textBoxUsername.Text;

            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            //command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            //adapter.SelectCommand = command;

            //adapter.Fill(table);

            //// check if this username already exists in the database
            //if (table.Rows.Count > 0)
            //{
                return true;
            //}
            //else
            //{
            //    return false;
            //}

        }



        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            //labelGoToLogin.ForeColor = Color.Yellow;
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            //labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
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
