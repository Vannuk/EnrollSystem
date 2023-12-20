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
    public partial class EnrollForm2 : Form
    {
        private SubMenuForm subMenuForm;
        private Enrollment enrollment;

        public EnrollForm2(SubMenuForm parentForm, Enrollment enrollment)
        {
            InitializeComponent();
            subMenuForm = parentForm;
            this.enrollment = enrollment;
        }

        private void BtnNext1_Click(object sender, EventArgs e)
        {
            EnrollForm3 enrollForm3 = new EnrollForm3(enrollment);
            subMenuForm.ShowNextButtonEnroll(this, enrollForm3);
            if (ChkAsso.Checked)
            {
                if (CHKASAccounting.Checked)
                {
                    enrollment.Major = "Accounting";
                }
                else if (CHKASEnglish.Checked)
                {
                    enrollment.Major = "English";
                }
                else if (CHKASExport.Checked)
                {
                    enrollment.Major = "Export-Image MGT";
                }
                else if (CHKASFinance.Checked)
                {
                    enrollment.Major = "Finance and Banking";
                }
                else if (CHKASInsurance.Checked)
                {
                    enrollment.Major = "Insurance";
                }
                else if (CHKASLogistic.Checked)
                {
                    enrollment.Major = "Logistic";
                }
                else
                {
                    MessageBox.Show("Please Select One Program", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                enrollment.Program = "Associate";
            }
            else if (ChkMaster.Checked)
            {
                if (CHKMSFinanceB.Checked)
                {
                    enrollment.Major = "Finance";
                }
                else if (CHKMSFinance.Checked)
                {
                    enrollment.Major = "Finance and Banking";
                }
                else if (CHKMSManagement.Checked)
                {
                    enrollment.Major = "Management";
                }
                else
                {
                    MessageBox.Show("Please Select One Program", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                enrollment.Program = "Master";
            }
            else if (ChkBach.Checked)
            {
                if (CHKBCAccounting.Checked)
                {
                    enrollment.Major = "Accounting";
                }
                else if (CHKBCBIT.Checked)
                {
                    enrollment.Major = "BusinessIT";
                }
                else if (CHKBCFINTECH.Checked)
                {
                    enrollment.Major = "Fintect";
                }
                else if (CHKBCIB.Checked)
                {
                    enrollment.Major = "Internation Business";
                }
                else if (CHKBCRMG.Checked)
                {
                    enrollment.Major = "Risk Mgt and Insurance";
                }
                else if (CHKBCSCML.Checked)
                {
                    enrollment.Major = "Supply Chain Mgt and Logistic";
                }
                else if (CHKBCFinanceB.Checked)
                {
                    enrollment.Major = "Finance and Banking";
                }
                else if (CHKBCTEFL.Checked)
                {
                    enrollment.Major = "Teaching English as Foreign Language";
                }
                else if (CHKBCEBC.Checked)
                {
                    enrollment.Major = "English For Business Communication";
                }
                else if (CHKBCCS.Checked)
                {
                    enrollment.Major = "Computer Science and Engineering";
                }
                else if (CHKBCETI.Checked)
                {
                    enrollment.Major = "English For Translation and Interpreting";
                }
                else
                {
                    MessageBox.Show("Please Select One Program", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                enrollment.Program = "Bachelor";
            }
            else
            {
                MessageBox.Show("Please Select One Major", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
