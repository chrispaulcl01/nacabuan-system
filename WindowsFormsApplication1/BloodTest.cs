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
                txtWeight.Text, cmbAllergies.Text, txtExistDiesease.Text, txtTypevax.Text, VaxDate.Value.Date))
            {
                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
