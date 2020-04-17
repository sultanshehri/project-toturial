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
    public partial class frmpic01 : Form
    {
        public frmpic01()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            try
            {
                // picTry.Image = Image.FromFile("I:\\DrAtif_IE_KAU\\20180322\\IE322_S18_KAU\\IE322_S18_KAU\\res\\A.jpg");
                // picTry.Image = Image.FromFile("C: \\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"); // This may not work if you change the computer, Then you have to change this line
                // picTry.Image = Image.FromFile("G:\\IE322_ALL\\_IE322_S20\\20180404\\tiny_cc_jaixjz.png"); //absolute path

                picTry.Image = Image.FromFile("C:/Users/سلطان/Desktop/Pics/KAU_Logo.jpg");
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            
        }
        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }

        private void picTry2_Click(object sender, EventArgs e)
        {

        }

        private void frmpic01_Load(object sender, EventArgs e)
        {

        }

        private void btnImageResource_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromFile("C:/Users/سلطان/Desktop/Pics/IE_Logo.jpg");
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }
    }
}

        