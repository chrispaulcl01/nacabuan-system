using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SkinTreatment : Form
    {
        public SkinTreatment()
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

        private void btnSavePreg_Click(object sender, EventArgs e)
        {
            if (patient.SaveSkinTreatment(txtPetID.Text, txtOwnersName.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                int.Parse(txtAge.Text), cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                txtWeight.Text, cmbSkinAllergies.Text, txtExistDisease.Text, cmbOperations.Text, DateOperation.Value.Date, txtOpTime.Text))
            {
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

        private void btnBackPreg_Click(object sender, EventArgs e)
        {
            Application.OpenForms["SkinTreatment"].Close();
        }
    }
}
