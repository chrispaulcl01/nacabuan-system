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
    public partial class Scheduling : Form
    {
        public Scheduling()
        {
            InitializeComponent();
        }

        private void btnChechUp_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            CheckUp ac = new CheckUp();
            ac.TopLevel = false;
            panelScheduling.Controls.Add(ac);
            ac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void btnPregnancy_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            Pregrancy cy = new Pregrancy();
            cy.TopLevel = false;
            panelScheduling.Controls.Add(cy);
            cy.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cy.Dock = DockStyle.Fill;
            cy.Show();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            Operation op = new Operation();
            op.TopLevel = false;
            panelScheduling.Controls.Add(op);
            op.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            op.Dock = DockStyle.Fill;
            op.Show();
        }
    }
}
