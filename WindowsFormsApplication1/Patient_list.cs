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
    public partial class Patient_list : Form
    {
        public Patient_list()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void Patient_list_Load(object sender, EventArgs e)
        {
            patient.loadpatientlist(GridPatienlist);
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        { 
            Dashboardfrm ac = new Dashboardfrm();
            ac.Show();
        }

        private void GridPatienlist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPatienlist.Rows[e.RowIndex];

                if (patient.PatientInfoViewer(row.Cells[0].Value.ToString()))
                {
                    Consultationfrm consultationfrm = new Consultationfrm();
                    consultationfrm.Show();

                    this.Close();
                    
                }
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            PaymentTransactfrm pay = new PaymentTransactfrm();
            pay.Show();

        }

        private void btnPListExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridPatienlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridPatienlist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GridPatienlist.Rows[e.RowIndex];
                this.txtPetidPList.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
              
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            patient.NameFilter(txtSearch.Text, GridPatienlist);
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            if (patient.PatientInfoViewer(this.txtPetidPList.Text))
            {
                PatientInfoViewer Pviewer = new PatientInfoViewer();
                Pviewer.Show();
            }
        }
    }
}
