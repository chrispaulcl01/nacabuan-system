using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Login log = new functions.Login();

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            
            

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginBtn_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUsername.ResetText();
            this.txtPassword.ResetText();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            lblUsername.Location = new Point(421, 215);
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                lblUsername.Location = new Point(421, 235);
            else
                lblUsername.Location = new Point(421, 215);
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            lblPassword.Location = new Point(423, 271);
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                lblPassword.Location = new Point(423, 293);
            else
                lblPassword.Location = new Point(423, 271);
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click_2(object sender, EventArgs e)
        {
            if (log.AuthenticateUser(txtUsername.Text, txtPassword.Text))
            {

                Home prof = new Home();
                prof.Show();
                this.Hide();
            }
            else if (String.IsNullOrWhiteSpace(this.txtUsername.Text) && String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Username and Password is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Account Denied!", "Incorrect Password or Username.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }

}

