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
    public partial class frmIE322_S20_KAU : Form
    {
        string username = "Sultan";//"Sultan"; //username
        string myPassword = "1234";// "1234"; //password
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;
        public frmIE322_S20_KAU()
        {
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void frmIE322_S20_KAU_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (Textuser.Text != username)
                    {
                        
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   
                        if (TextPW.Text != myPassword)
                        {
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            attempt = 1; 
                            loggedIn = true;
                            MessageBox.Show("Hi " + username + ", you are logged in.");                       


                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            BtnLogin.Text = "Logout";
                            
                            break; 
                        }

                    }
                }
            }
            else
            {
                BtnLogin.Text = "Login";
                loggedIn = false;

                Textuser.Clear();
                TextPW.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }
            }


        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            frmpic01 frm = new frmpic01();
            frm.ShowDialog();
        }

        private void btnPictureBox2_Click(object sender, EventArgs e)
        {
            frmpic02 frm = new frmpic02();
            frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
