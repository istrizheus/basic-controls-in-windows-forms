using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class BasicControls : Form
    {
        public BasicControls()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // lblPassword.Visible = true;
            lblPassword.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblPassword.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUser.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Text = txtPassword.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void BasicControls_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + txtUser.Text + "! Your password is: " + txtPassword.Text + ". Keep it safe!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnExit.Visible = !btnExit.Visible;
        }
    }
}
