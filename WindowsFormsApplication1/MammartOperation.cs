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
    public partial class MammartOperation : Form
    {
        public MammartOperation()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
