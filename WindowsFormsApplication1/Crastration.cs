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
    public partial class Crastration : Form
    {
        public Crastration()
        {
            InitializeComponent();
        }

        functions.Patient patient = new functions.Patient();

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCrast_Click(object sender, EventArgs e)
        {
            if (patient.SavePatientCrastration(txtPetID.Text, txtOwnersname.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                int.Parse(txtAge.Text), cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                txtWeight.Text, cmbAllergies.Text, txtExDisease.Text, cmbOperations.Text, DateOperetion.Value.Date, txtOpTime.Text))
            {
                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBackCrast_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Crastration"].Close();
        }
    }
}
