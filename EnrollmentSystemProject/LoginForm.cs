using EnrollmentSystemProject.EnrollmentSystem.Classes;
using EnrollmentSystemProject.EnrollmentSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystemProject
{
    public partial class LoginForm : Form
    {
        private LoginAuthentication loginauthentication;
        public LoginForm()
        {
            InitializeComponent();
            loginauthentication = new LoginAuthentication();
        }
        private void BtnSingUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want create new user!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            CreateUserForm createUser = new CreateUserForm();
            createUser.Show();
            TxtUsername.Clear();
            TxtPassword.Clear();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string UserName = TxtUsername.Text;
            string Password = TxtPassword.Text;
            UserLogin userlogin = loginauthentication.AuthenticationUser(UserName, Password);
            {
                if (userlogin != null)
                {
                    MessageBox.Show("You've logged in successfully!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    SubMenuForm subMenuForm = new SubMenuForm(userlogin);
                    subMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your User Name or Userpassword", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
        }
    }
}
