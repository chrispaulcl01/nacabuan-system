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
            else if (cmbLoadServices.Text == "Vaccination")
            {
                patient.LoaddVaccination(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Castration")
            {
                patient.LoaddCrastration(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Ligate")
            {
                patient.LoaddLygaidae(gridPatientData);
            }
            else if (cmbLoadServices.Text == "Deworming")
            {
                patient.LoadDeworming(gridPatientData);
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
                        SkinTreatmentView skinUp = new SkinTreatmentView();
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
                        CPTestView cptUp = new CPTestView();
                        cptUp.Show();
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
                        CDTestView cdtnUp = new CDTestView();
                        cdtnUp.Show();
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

            //else if (cmbLoadServices.Text == "Deworming")
            //{
               // if (e.RowIndex >= 0)
                //{
                 //  DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                  //  if (patient.PatientInfoViewerDeworming(row.Cells[0].Value.ToString()))
                  //  {
                  //      DewormingView dewormview = new DewormingView();
                    //    dewormview.Show();
//}
                //}
//}

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

            else if (cmbLoadServices.Text == "Vaccination")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerVaccination(row.Cells[0].Value.ToString()))
                    {
                        VaccinationViewerfrm vaxview = new VaccinationViewerfrm();
                        vaxview.Show();
                        
                    }
                }
            }

            else if (cmbLoadServices.Text == "Castration")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerCrastration(row.Cells[0].Value.ToString()))
                    {
                        CrastrationViewfrm crasview = new CrastrationViewfrm();
                        crasview.Show();
                    }
                }
            }

            else if (cmbLoadServices.Text == "Ligate")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gridPatientData.Rows[e.RowIndex];

                    if (patient.PatientInfoViewerLygaedae(row.Cells[0].Value.ToString()))
                    {
                        lygaeidaeViewerfrm ligview = new lygaeidaeViewerfrm();
                        ligview.Show();
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
