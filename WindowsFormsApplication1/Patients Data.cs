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
    public partial class Staff_Memberfrm : Form
    {
        public Staff_Memberfrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLoadServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoadServices.Text == "SkinTreatment")
            {
                patient.LoadSkinTreatment(gridPatientData);
            }

            else if (cmbLoadServices.Text == "CPT")
            {
                patient.LoadCPT(gridPatientData);
            }

            else if (cmbLoadServices.Text == "CDT")
            {
                patient.LoadCDT(gridPatientData);
            }
            else if (cmbLoadServices.Text == "BloodParasite")
            {
                patient.LoadBloodParasite(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Deworming")
            {
                patient.LoadDeworming(gridPatientData);
            }
        }
    }
}
