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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
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
                pictureBox3.Image = new Bitmap(opf.FileName);
                //fileName = opf.FileName;
            }
        }

        private void BtnBrowse1_Click(object sender, EventArgs e)
        {
            //DECLARE


            //INPUT
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            //PROCESS
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opf.FileName);
                //fileName = opf.FileName;
            }
        }
    }
}
