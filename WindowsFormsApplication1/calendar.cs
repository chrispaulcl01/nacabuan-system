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
            patient.LoaddPatients(gridBookingSchedule);
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridBookingSchedule.Rows[e.RowIndex];

                if (patient.GetPatient(row.Cells[0].Value.ToString()))
                {
                    Consultationfrm consultationfrm = new Consultationfrm();
                    consultationfrm.Show();

                    this.Close();
                    Application.OpenForms["Home"].Hide();
                }
            }
        }
    }
}
