using MediInfo;
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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public IUserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            //labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            // check if the user exists or not
            if (_userService.is_valid(username,password))
            {
                this.Hide();
                DoctorsDashboard Form = new DoctorsDashboard();
                Form.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;

        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            //labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            //labelGoToSignUp.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
