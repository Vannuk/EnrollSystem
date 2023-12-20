using EnrollmentSystemProject.EnrollmentSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemProject.EnrollmentSystem.Forms
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            //DECLARE
            UserLogin CreateUser = new UserLogin();
            CreateUser.UserID = TxtUserID.Text;
            CreateUser.UserName = txtUsername.Text;
            CreateUser.Password = txtPassword.Text;
            CreateUser.Role = cbPosition.Text;
            //PROCESS
            if (CreateUser.CreateUsers())
            {
                MessageBox.Show("User Created Succesful !");
                txtUsername.Clear();
                txtPassword.Clear();
                txtPhoneNo.Clear();
                txtEmail.Clear();
                TxtUserID.Clear();
                cbPosition.Items.Clear();
            }
            else
            {
                MessageBox.Show("User Created Failed !");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            LoginForm userlog = new LoginForm();
            userlog.Show();
            this.Hide();
        }
    }
}
