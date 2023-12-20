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
    public partial class EnrollForm1 : Form
    {
        private SubMenuForm subMenuForm;
        private Enrollment enrollment;

        public EnrollForm1(SubMenuForm parentForm, Enrollment enrollment)
        {
            InitializeComponent();
            subMenuForm = parentForm;
            this.enrollment = enrollment;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            enrollment.StudID = TxtStuID.Text;
            enrollment.FullNameKH = TxtFNKH.Text;
            enrollment.FullNameEN = TxtFNENG.Text;
            enrollment.Gender = CBBGender.Text;
            enrollment.DOB = DateTime.Parse(DTPDOB.Text);
            enrollment.ParentContact = TxtETN.Text;
            enrollment.Email = TxtEmail.Text;
            enrollment.Address = TxtPMA.Text;
            enrollment.PhoneNumber = TxtTPN.Text;
            EnrollForm2 enrollForm2 = new EnrollForm2(subMenuForm, enrollment);
            subMenuForm.ShowNextButtonEnroll(this, enrollForm2);
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
                pictureBox2.Image = new Bitmap(opf.FileName);
            }
        }

    }
}
