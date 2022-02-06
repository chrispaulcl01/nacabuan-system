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
    public partial class Deworming : Form
    {
        public Deworming()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSaveDewarm_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Application.OpenForms["Deworming"].Close();
        }

        private void btnBackDewarm_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Deworming"].Close();
        }
    }
}
