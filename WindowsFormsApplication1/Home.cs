using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void Cliniccal_btn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void Home_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnTransHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            Dashboardfrm ac = new Dashboardfrm();
            ac.TopLevel = false;
            Home_panel.Controls.Add(ac);
            ac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void Cliniccal_btn_Click_1(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            calendar ac = new calendar();
            ac.TopLevel = false;
            Home_panel.Controls.Add(ac);
            ac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void PatientList_btn_Click(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            Patient_list ac = new Patient_list();
            ac.TopLevel = false;
            Home_panel.Controls.Add(ac);
            ac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void btnTransHistory_Click_1(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            TransactionHistory th = new TransactionHistory();
            th.TopLevel = false;
            Home_panel.Controls.Add(th);
            th.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            th.Dock = DockStyle.Fill;
            th.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            Staff_Memberfrm staff = new Staff_Memberfrm();
            staff.TopLevel = false;
            Home_panel.Controls.Add(staff);
            staff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            staff.Dock = DockStyle.Fill;
            staff.Show();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            Home_panel.Controls.Clear();
            btnPReport report = new btnPReport();
            report.TopLevel = false;
            Home_panel.Controls.Add(report);
            report.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            report.Dock = DockStyle.Fill;
            report.Show();
        }
    }
}
