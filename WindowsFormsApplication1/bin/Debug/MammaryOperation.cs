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
    public partial class MammaryOperation : Form
    {
        public MammaryOperation()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSavePreg_Click(object sender, EventArgs e)
        {

        }

        private void btnSavemammry_Click(object sender, EventArgs e)
        {
            if (patient.SaveMammryPatient(txtPetID.Text, txtOwnersName.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                int.Parse(txtAge.Text), cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                txtWeight.Text, cmbAllergies.Text, txtExistDiesease.Text, txtTypevax.Text, VaxDate.Value.Date))
                
            {
                patient.SavePatientMammaryResult(txtPetID.Text, txtResultSuperchen.Text, txtResultTotalprotein.Text, txtResultAlbumin.Text, txtResultGlobulin.Text, txtResultAGration.Text, txtResultASTsgot.Text, txtResultALTsgpt.Text,
                txtResultAlkPhosphatase.Text, txtResultGct.Text, txtResultTotalBilirubin.Text, txtResultBun.Text, txtResultCreatinine.Text, txtResultRenalTech.Text);

                patient.SavePatientMammaryRange(txtPetID.Text, txtRangeSuperchen.Text, txtRangeTotalProtein.Text, txtRangeAlbumin.Text, txtRangeGlobulin.Text, txtRangeAGratio.Text, txtRangeASTsgot.Text, txtRangeALTsgpt.Text,
                txtRangealkPhos.Text, txtRangeGCT.Text, txtRangeTotalBilirubin.Text, txtRangeBun.Text, txtRangeCreatinine.Text, txtRangeRenalTech.Text);
                
                patient.SavePatientMammaryUnits(txtPetID.Text, txtUnitsSuperchen.Text, txtUnitsTotalprotein.Text, txtUnitsAlbimin.Text, txtUnitsGlobulin.Text, txtUnitsAGratio.Text, txtUnitsASTsgot.Text, txtUnitsALTsgpt.Text,
                txtUnitsALKphos.Text, txtUnitsGCT.Text, txtUnitsTotalbilirubin.Text, txtUnitsBUN.Text, txtUnitsCreatinine.Text, txtUnitsRenalTech.Text);

                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                val.Pet_id = this.txtPetID.Text;
                val.OwnersName = this.txtOwnersName.Text;
                val.Pet_name = this.txtPatientName.Text;

                frmRX rx = new frmRX();
                rx.Show();

            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBackMamm_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MammaryOperation"].Close();
        }
    }
}
