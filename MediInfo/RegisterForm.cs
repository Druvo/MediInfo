using MediInfo;
using MediInfo.Models;
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

namespace Csharp_Login_And_Register
{
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {
        public IUserService _userService;

        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();

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


        }

        
        // check if the username already exists
        public Boolean checkUsername(string email)
        {

            if (_userService.check_existing_user(email))
            {
                return true;
            }
            else
            {
                return false;
            }

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
        public bool checkTextBoxesValues(string name, string email, string bio, string passs, string cpass)
        {
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }            
            if (string.IsNullOrWhiteSpace(bio))
            {
                MessageBox.Show("Please enter your bio!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }            
            if (string.IsNullOrWhiteSpace(passs))
            {
                MessageBox.Show("Please enter a password!", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }            
            if (string.IsNullOrWhiteSpace(cpass))
            {
                MessageBox.Show("Please confirm your password", "Invalid input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                is_valid = false;
            }
            return is_valid;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //// add a new user
            Cursor.Current = Cursors.WaitCursor;
            string name = textBoxFirstname.Text;
            string email = textBoxEmail.Text;
            //string user = textBoxUsername.Text;
            string bio = textBox1.Text;
            string passs = textBoxPassword.Text;
            string cpass = textBoxPasswordConfirm.Text;
            if (checkTextBoxesValues(name, email, bio, passs, cpass))
            {
                // check if the password equal the confirm password
                if (passs.Equals(cpass))
                {
                    // check if this username already exists
                    if (checkUsername(email))
                    {
                        MessageBox.Show("This Email Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User user = new User();
                        user.Email = email;
                        user.Password = passs;
                        user.Username = "";
                        user.Name = name;
                        user.Bio = bio;
                        user.IsActive = false;
                        
                        // execute the query
                        if (_userService.Insert(user))
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
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
