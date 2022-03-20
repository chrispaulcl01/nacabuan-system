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
    public partial class BloodTestUpdate1 : Form
    {
        public BloodTestUpdate1()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void BloodTestUpdate1_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPhoneNumber.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbGender.Text = val.Pet_gender;
            this.bdayDatepicker.Text = val.Pet_bday;
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.cmbAnimalBreed.Text = val.Pet_breed;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.cmbAllergies.Text = val.Pet_skinallergies;
            this.txtExistDiesease.Text = val.Pet_existdisease;
            this.cmbOperation.Text = val.Operation;
            this.txtTypevax.Text = val.Typevax;
            this.VaxDate.Value = val.Vaxdate;
        }

        private void btnSavemammry_Click(object sender, EventArgs e)
        {
            if (patient.UpdateBloodTestPatient(this.txtPetID.Text, this.txtOwnersName.Text, this.txtPhoneNumber.Text, this.txtAddress.Text, this.txtPatientName.Text,
               int.Parse(this.txtAge.Text), this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.cmbAnimalBreed.Text,
               this.txtWeight.Text, this.cmbAllergies.Text, this.txtExistDiesease.Text, this.cmbOperation.Text, this.txtTypevax.Text, this.VaxDate.Value.Date))
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
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
