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
    public partial class EnrollForm3 : Form
    {
        private Enrollment enrollment;

        public EnrollForm3(Enrollment enrollment)
        {
            InitializeComponent();
            this.enrollment = enrollment;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //DECLARE
            //INPUT
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            //PROCESS
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opf.FileName);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
                enrollment.RegDate = DateTime.Parse(DTPReg.Text);
                enrollment.UserID = TxtEmpID.Text;
                if (CHKWeekDay.Checked)
                {
                    if (CHKAMorning1.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Morning(M1)";
                    }
                    else if (CHKAMorning2.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Morning(M2)";
                    }
                    else if (CHKAAfternoon.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Afternoon";
                    }
                    else if (CHKAEvening.Checked)
                    {
                        enrollment.StudyTime = "WeekDay Evening";
                    }
                }
                else if (CHKWeekend.Checked)
                {
                    enrollment.StudyTime = "Weekend";
                }
                if (enrollment.InsertEnrollStudent(enrollment))
                {
                    //Output
                    MessageBox.Show("Student Enrollment Data is Insert Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Student Enrollment Data is Insert Unsuccessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
    }
}
