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
    public partial class SubMenuForm : Form
    {
        private EnrollForm1 enrollForm1;
        private EnrollForm2 enrollForm2;
        private EnrollForm3 enrollForm3;
        private UserLogin user;
        public static Form ActiveForm = null;
        bool checkReport = false;
        public SubMenuForm(UserLogin user)
        {
            InitializeComponent();
            panel10.Height = 0;
            this.user = user;
            DisplayButton();
            DisplayWelcomeMessage();
        }
        public void openChildForm(Form form)
        {
            //ActiveForm.Close();
            ActiveForm = form;
            if (ActiveForm != null)
            {
                ActiveForm.TopLevel = false;
                ActiveForm.FormBorderStyle = FormBorderStyle.None;
                ActiveForm.Dock = DockStyle.Fill;
                OpenChildForm.Controls.Add(ActiveForm);
                OpenChildForm.Tag = ActiveForm;
                ActiveForm.BringToFront();
                ActiveForm.Show();
            }
        }
        private void BtnEnrollmentReport_Click(object sender, EventArgs e)
        {
            openChildForm(new EnrollmentReport());
        }
        private void BtnScholarshipReport_Click(object sender, EventArgs e)
        {
            openChildForm(new ScholarshipReportForm());
        }
        private void BtnPolicyIncomeReport_Click(object sender, EventArgs e)
        {
            openChildForm(new PolicyReportForm());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm userlog = new LoginForm();
            userlog.Show();
            this.Hide();
        }
        private void DisplayButton()
        {
            switch(user.Role)
            {
                case "Admin":
                    BtnDepartment.Visible = true;
                    BtnPayment.Visible = false;
                    BtnDashboard.Visible = false;
                    BtnPolicyReport.Visible = false;
                    BtnScholarshipReport.Visible = false;
                    BtnEnrollmentReport.Visible = false;
                    BtnReport.Visible = false;
                    BtnStudent.Visible = false;
                    BtnTransectionlog.Visible = true;
                    BtnEnroll.Visible = false;
                    BtnSetting.Visible = true;

                    break;
                case "Receptionist":
                    BtnDashboard.Visible = true;
                    BtnEnroll.Visible = true;
                    BtnPayment.Visible = false;
                    BtnDepartment.Visible = true;
                    BtnStudent.Visible = false;
                    BtnReport.Visible = true;
                    BtnPolicyReport.Visible = true;
                    BtnScholarshipReport.Visible = true;
                    BtnEnrollmentReport.Visible = true;
                    BtnTransectionlog.Visible = false;
                    BtnSetting.Visible = true;

                    break;
                case "Cashier":
                    BtnDepartment.Visible = false;                 
                    BtnDashboard.Visible = true;
                    BtnPolicyReport.Visible = true;
                    BtnScholarshipReport.Visible = true;
                    BtnEnrollmentReport.Visible = true;
                    BtnReport.Visible = true;
                    BtnEnroll.Visible = false;
                    BtnSetting.Visible = true;  
                    break;
                case "ERU Manager":
                    BtnDepartment.Visible = true;
                    BtnPayment.Visible = false;
                    BtnDashboard.Visible = false;
                    BtnPolicyReport.Visible = true;
                    BtnScholarshipReport.Visible = true;
                    BtnEnrollmentReport.Visible = true;
                    BtnReport.Visible = true;
                    BtnStudent.Visible = false;
                    BtnTransectionlog.Visible = false;
                    BtnEnroll.Visible = true;
                    BtnSetting.Visible = true;
                    break;
                default:

                    break;
            }
        }
        private void DisplayWelcomeMessage()
        {
            LabelWelcome.Text = "Welcome, " + user.UserName + "!";
        }
        private void BtnEnroll_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollForm1 = new EnrollForm1(this,enrollment);
            enrollForm1.TopLevel = false;
            enrollForm1.FormBorderStyle = FormBorderStyle.None;
            enrollForm1.Dock = DockStyle.Fill;
            OpenChildForm.Controls.Add(enrollForm1);
            enrollForm1.Show();
        }
        public void ShowNextButtonEnroll(Form currentForm, Form nextForm)
        {
            currentForm.Dispose();
            nextForm.TopLevel = false;
            nextForm.FormBorderStyle = FormBorderStyle.None;
            nextForm.Dock = DockStyle.Fill;
            OpenChildForm.Controls.Add(nextForm);
            OpenChildForm.Tag = nextForm;
            nextForm.Show();
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (checkReport == false)
            {
                panel10.Height = 150;
                checkReport = true;
            }
            else
            {
                panel10.Height = 0;
                checkReport = false;
            }
        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DashBoardForm());
        }

        private void BtnPayment_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PaymentForm());
        }

        private void BtnStudent_Click_1(object sender, EventArgs e)
        {
            openChildForm(new StudentForm());
        }

        private void BtnDepartment_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DepartmentForm());
        }

        private void BtnTransectionlog_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TransactionLogForm());
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingForm());
        }

        private void BtnScholarshipReport_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ScholarshipReportForm());
        }

        private void BtnEnrollmentReport_Click_1(object sender, EventArgs e)
        {
            openChildForm(new EnrollmentReport());
        }

        private void BtnPolicyReport_Click(object sender, EventArgs e)
        {
            openChildForm(new PolicyReportForm());
        }
    }
}
