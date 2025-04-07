using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dabing1202Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_ready = new Icon(SystemIcons.Information, 40, 40);
        public frmCreative()
        {
            InitializeComponent();
        }

        private void frmCreative_Load(object sender, EventArgs e)
        {
            txtSource.Text = "D:\\Creative\\Source\\";
            txtProcessedFile.Text = "D:\\Creative\\Processed\\";
            txtDest.Text = "D:\\Creative\\Destination\\";
            optGeneratelog.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "Invalid Source Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtSource," ");
              
            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "Invalid Source Directory");
                txtProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtProcessedFile, " ");
             if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "Invalid Destination Directory");
                txtDest.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
                errMessage.SetError(txtDest, " ");
            watchDir.EnableRaisingEvents = true;
            watchDir.Path = txtSource.Text;
            mnuNotify.Icon = m_ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = true;
            this.Hide();
        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            if(Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
            {
                txtProcessedFile.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
            {
                txtDest.BackColor = Color.Pink;
            }
        }

        private void txtDest_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
            {
                txtProcessedFile.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
            {
                txtDest.BackColor = Color.Pink;
            }
        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
            {
                txtSource.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
            {
                txtProcessedFile.BackColor = Color.Pink;
            }
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
            {
                txtDest.BackColor = Color.Pink;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void configuerApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }
    }
}
