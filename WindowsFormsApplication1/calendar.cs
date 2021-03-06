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

            if (txtSchedIdentifier.Text == "Vaccine")
            {
                patient.CountPatientsTodayVax(this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
                this.txtPatientToday.Text = val.Total_schedtoday.ToString();
                patient.VaxCalendarFilter(gridBookingSchedule, this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
            }

            else if (txtSchedIdentifier.Text == "Crastration") 
            {
                patient.CountPatientsTodayCras(this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
                this.txtPatientToday.Text = val.Total_schedtoday.ToString();
                patient.CrasCalendarFilter(gridBookingSchedule, this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
            }

            else if (txtSchedIdentifier.Text == "Lygate")
            {
                patient.CountPatientsTodayLygate(this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
                this.txtPatientToday.Text = val.Total_schedtoday.ToString();
                patient.LygateCalendarFilter(gridBookingSchedule, this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
            }

            else if (txtSchedIdentifier.Text == "Deworming")
            {
                patient.CountPatientsTodayDeworm(this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
                this.txtPatientToday.Text = val.Total_schedtoday.ToString();
                patient.DewormCalendarFilter(gridBookingSchedule, this.dateSchedule.Value.ToString("MM"), this.dateSchedule.Value.ToString("dd"),
                this.dateSchedule.Value.ToString("yy"));
            }
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

            else if (txtSchedIdentifier.Text == "Lygate")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridBookingSchedule.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerLygaedae(row.Cells[0].Value.ToString()))
                    {
                        lygaeidaeViewerfrm luview = new lygaeidaeViewerfrm();
                        luview.Show();
                    }
                }
            }

            else if (txtSchedIdentifier.Text == "Crastration")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridBookingSchedule.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerCrastration(row.Cells[0].Value.ToString()))
                    {
                        CrastrationViewfrm crasiew = new CrastrationViewfrm();
                        crasiew.Show();
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
            this.txtSchedIdentifier.Text = "Lygate";
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

        private void gridBookingSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
