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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Booking booking = new functions.Booking();
        functions.Patient patient = new functions.Patient();


        private void calendar_pic_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void hide_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void calendar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            patient.LoadPatients(gridBookingSchedule, dateSchedule.Text);
        }

        private void btnProcTransac_Click(object sender, EventArgs e)
        {

        }

        private void gridBookingSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (txtSchedIdentifier.Text == "Deworming")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridBookingSchedule.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerDeworming(row.Cells[0].Value.ToString()))
                    {
                        DewormingView dewormview = new DewormingView();
                        dewormview.Show();
                    }
                }
            }

            else if (txtSchedIdentifier.Text == "Vaccine")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridBookingSchedule.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerVaccination(row.Cells[0].Value.ToString()))
                    {
                        VaccinationViewerfrm vaxview = new VaccinationViewerfrm();
                        vaxview.Show();
                    }
                }
            }
        }

        private void cmbLoadOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            txtSchedIdentifier.Clear();
            this.txtSchedIdentifier.Text = "Vaccine";
            patient.LoaddVaccination(gridBookingSchedule);
        }

        private void btnCrastration_Click(object sender, EventArgs e)
        {
            txtSchedIdentifier.Clear();
            this.txtSchedIdentifier.Text = "Crastration";
            patient.LoaddCrastration(gridBookingSchedule);
        }

        private void btnLygaeidae_Click(object sender, EventArgs e)
        {
            txtSchedIdentifier.Clear();
            this.txtSchedIdentifier.Text = "Lygaeidae";
            patient.LoaddLygaidae(gridBookingSchedule);
        }

        private void btnDeworming_Click(object sender, EventArgs e)
        {
            txtSchedIdentifier.Clear();
            this.txtSchedIdentifier.Text = "Deworming";
            patient.LoadDeworming(gridBookingSchedule);
        }

        private void gridBookingSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }
    }
}
