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
    public partial class Deworming : Form
    {
        public Deworming()
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

        private void btnSaveDewarm_Click(object sender, EventArgs e)
        {
            if (patient.SaveDewormedPatient(txtPetID.Text, txtOwnersName.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                int.Parse(txtAge.Text), cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                cmbOperation.Text, Dewormdate2weeks.Text, txtDewormMedicine2weeks.Text, Dewormdate4weeks.Text, txtDewormMedicine4weeks.Text, Dewormdate6weeks.Text,txtDewormMedicine6weeks.Text,
                 Dewormdate8weeks.Text, txtDewormMedicine8weeks.Text, Dewormdate10weeks.Text, txtDewormMedicine10weeks.Text, Dewormdate12weeks.Text, txtDewormMedicine12weeks.Text)) 
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


            Home home = new Home();
            home.Show();
            Application.OpenForms["Deworming"].Close();
        }

        private void btnBackDewarm_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Deworming"].Close();
        }
    }
}
