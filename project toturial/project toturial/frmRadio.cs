using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_toturial
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void BtnRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true)
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromArgb(255, 255, 0);
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow2.ForeColor = Color.FromName("yellow");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoBlue.Checked = false;
            RdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            RdoGreen.ForeColor = Color.FromName("black");
            RdoBlue.ForeColor = Color.FromName("black");
            RdoYellow.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYellow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYellow2.ForeColor = Color.FromName("black");
        }
    }
}
