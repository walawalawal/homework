using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
                if ((txtCarNo.Text == "" || (txtCarNo.Text == null)))
                {
                    MessageBox.Show("Please Specify a valid value" +

                        "of the car Number", "Error in input");
                    txtCarNo.Focus();
                }
            }

        private void txtOilChanged_Click(object sender, EventArgs e)
        {
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please Specify a Valid Car Number"

                   );
                txtCarNo.Focus();
                return;
            }
            if (Convert.ToInt32(txtWorkerld.Text) < 1)
            {
                MessageBox.Show("Please Specify a Valid Worker id");
                txtCarNo.Focus();
                return;
            }
            if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
            {
                MessageBox.Show("Please Specify a Valid Date");
                dateTimePicker1.Focus();
                return;
            }
       
            
        }
       
            

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
