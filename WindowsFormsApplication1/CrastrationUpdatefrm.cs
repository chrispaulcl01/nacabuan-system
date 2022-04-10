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
    public partial class CrastrationUpdatefrm : Form
    {
        public CrastrationUpdatefrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void CrastrationUpdatefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCrast_Click(object sender, EventArgs e)
        {
            if (patient.UpdateCrastrationOpPatient(this.txtPetID.Text, this.txtOwnersname.Text, this.txtPhoneNumber.Text, this.txtAddress.Text, this.txtPatientName.Text,
                int.Parse(this.txtAge.Text), this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.cmbAnimalBreed.Text, this.txtWeight.Text,
                this.cmbAllergies.Text, this.txtExDisease.Text, this.cmbOperations.Text, this.DateOperetion.Value.Date, this.txtOpTime.Text))
            {

                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //patient.DeleteSkinPatientData(this.txtPetID.Text);

            }
            else
            {
                MessageBox.Show("Failed to Saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btnBackCrast_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
