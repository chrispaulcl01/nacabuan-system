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
            else if (cmbLoadServices.Text == "Pregnancy")
            {
                patient.LoadPregCesarean(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Eye Operation")
            {
                patient.LoadEyeOperation(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Ear Operation")
            {
                patient.LoadEarOperation(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Mammary Gland")
            {
                patient.LoadMammary(gridPatientData);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbLoadServices.Text == "SkinTreatment")
            {
                patient.NameFilterSkin(txtSearch.Text, gridPatientData);
            }

            else if (cmbLoadServices.Text == "CPT")
            {
                patient.NameFilterCPT(txtSearch.Text, gridPatientData);
            }
            
            
        }

        private void gridPatientData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridPatientData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cmbLoadServices.Text == "SkinTreatment") 
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerSkin(row.Cells[0].Value.ToString()))
                    {
                        SkinTreatmentUpdate skinUp = new SkinTreatmentUpdate();
                        skinUp.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "CPT")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerCPT(row.Cells[0].Value.ToString()))
                    {
                        SkinTreatmentUpdate skinUp = new SkinTreatmentUpdate();
                        skinUp.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "CDT")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerCDT(row.Cells[0].Value.ToString()))
                    {
                        SkinTreatmentUpdate skinUp = new SkinTreatmentUpdate();
                        skinUp.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "BloodParasite")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerBloodTest(row.Cells[0].Value.ToString()))
                    {
                        BloodTestView bloodtview = new BloodTestView();
                        bloodtview.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Deworming")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerDeworming(row.Cells[0].Value.ToString()))
                    {
                        DewormingView dewormview = new DewormingView();
                        dewormview.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Pregnancy")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerPregCesarean(row.Cells[0].Value.ToString()))
                    {
                        PregrancyCesareanView pregcesview = new PregrancyCesareanView();
                        pregcesview.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Ear Operation")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerEarOperation(row.Cells[0].Value.ToString()))
                    {
                        EarOperationView earop = new EarOperationView();
                        earop.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Eye Operation")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerEyeOperation(row.Cells[0].Value.ToString()))
                    {
                        EyeOperationView eyeop = new EyeOperationView();
                        eyeop.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Mammary Gland")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerMammaryGland(row.Cells[0].Value.ToString()))
                    {
                        MammryGrandView mammgland = new MammryGrandView();
                        mammgland.Show();
                    }
                }
            }
        }

        private void gridPatientData_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void gridPatientData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void Staff_Memberfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
