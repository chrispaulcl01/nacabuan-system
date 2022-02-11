﻿using System;
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
    public partial class BloodTest : Form
    {
        public BloodTest()
        {
            InitializeComponent();
        }

        functions.Patient patient = new functions.Patient();

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSavemammry_Click(object sender, EventArgs e)
        {
           if (patient.SaveBloodtestPatient(txtPetID.Text, txtOwnersName.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                int.Parse(txtAge.Text), cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                txtWeight.Text, cmbAllergies.Text, txtExistDiesease.Text, cmbOperation.Text, txtTypevax.Text, VaxDate.Value.Date))
            {
                patient.SavePatientBloodTestResult(txtPetID.Text, txtResultSuperchen.Text, txtResultTotalprotein.Text, txtResultAlbumin.Text, txtResultGlobulin.Text, txtResultAGration.Text, txtResultASTsgot.Text, txtResultALTsgpt.Text,
               txtResultAlkPhosphatase.Text, txtResultGct.Text, txtResultTotalBilirubin.Text, txtResultBun.Text, txtResultCreatinine.Text, txtResultRenalTech.Text);

                patient.SavePatientBloodTestRange(txtPetID.Text, txtRangeSuperchen.Text, txtRangeTotalProtein.Text, txtRangeAlbumin.Text, txtRangeGlobulin.Text, txtRangeAGratio.Text, txtRangeASTsgot.Text, txtRangeALTsgpt.Text,
                txtRangealkPhos.Text, txtRangeGCT.Text, txtRangeTotalBilirubin.Text, txtRangeBun.Text, txtRangeCreatinine.Text, txtRangeRenalTech.Text);

                patient.SavePatientBloodTestUnits(txtPetID.Text, txtUnitsSuperchen.Text, txtUnitsTotalprotein.Text, txtUnitsAlbimin.Text, txtUnitsGlobulin.Text, txtUnitsAGratio.Text, txtUnitsASTsgot.Text, txtUnitsALTsgpt.Text,
                txtUnitsALKphos.Text, txtUnitsGCT.Text, txtUnitsTotalbilirubin.Text, txtUnitsBUN.Text, txtUnitsCreatinine.Text, txtUnitsRenalTech.Text);

                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Home home = new Home();
                home.Show();
                Application.OpenForms["BloodTest"].Close();
            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["BloodTest"].Close();
        }
    }
}
