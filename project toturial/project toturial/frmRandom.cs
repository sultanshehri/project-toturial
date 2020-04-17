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
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(y.Next(1, 100));
        }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            btnGenerateRandom.BackColor = Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
        }
    }
}
