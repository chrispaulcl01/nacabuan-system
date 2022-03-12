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
    public partial class ServicesAndOperation : Form
    {
        public ServicesAndOperation()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            Services ser = new Services();
            ser.TopLevel = false;
            panelScheduling.Controls.Add(ser);
            ser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ser.Dock = DockStyle.Fill;
            ser.Show();
        }

        private void btnPregnancy_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            PregrancyCesareanView cy = new PregrancyCesareanView();
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

        private void btnSchedService_Click(object sender, EventArgs e)
        {
            panelScheduling.Controls.Clear();
            SchedService schedService = new SchedService();
            schedService.TopLevel = false;
            panelScheduling.Controls.Add(schedService);
            schedService.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            schedService.Dock = DockStyle.Fill;
            schedService.Show();
        }
    }
}
