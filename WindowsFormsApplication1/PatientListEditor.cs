using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class PatientListEditor : Form
    {
        public PatientListEditor()
        {
            InitializeComponent();
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void PatientListViewer_Load(object sender, EventArgs e)
        {
            //this.txtPetID.Text = val.PetID;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPatientName.Text = val.Pet_name;
            this.txtContactNo.Text = val.Contactno;
            this.cmbGender.Text = val.Pet_gender;
            this.bdayDatepicker.Text = val.Pet_bday;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.txtAnimalBreed.Text = val.Pet_breed;
            this.txtTemperature.Text = val.Temp.ToString();
            this.dateLastvaccinedate.Text =  val.lastvacinedate.ToString();
            this.txtExistingConditions.Text = val.Exsist_con;
            this.txtAllergies.Text = val.Allergies;
            this.txtTypeOfVaccine.Text = val.Type_vaccine;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.txtQuestion.Text = val.Question;
            this.cmbStool.Text = val.Stool;
            this.cmbBehaAtti.Text = val.Behav_att;
            this.cmbAppetite.Text = val.Appetite;
            this.cmbDrinkingwater.Text = val.Drink;
            this.cmbDiagnosis.Text = val.Diagnosis;
                
        }
        
        private void btnPConsultExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrxhistory_Click(object sender, EventArgs e)
        {
            if (patient.ViewRXHistory(this.txtPetID.Text)) 
            {
                frmRX rxfrm = new frmRX();
                rxfrm.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (patient.UpdatePatient(this.txtPetID.Text, this.txtOwnersName.Text, this.txtPatientName.Text, int.Parse(this.txtAge.Text),
                this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.txtAnimalBreed.Text, this.txtContactNo.Text,
                double.Parse(this.txtTemperature.Text), DateTime.Parse(this.dateLastvaccinedate.Text), this.txtExistingConditions.Text,
                this.txtAllergies.Text, this.txtTypeOfVaccine.Text, double.Parse(this.txtWeight.Text), this.txtQuestion.Text, this.cmbStool.Text,
                this.cmbBehaAtti.Text, this.cmbAppetite.Text, this.cmbDrinkingwater.Text, this.cmbDiagnosis.Text))
            {
                
                    MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    patient.DeletePatientlist(this.txtPetID.Text);
                
            }
            else
            {
                MessageBox.Show("Failed to Saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

            frmRX rx = new frmRX();
            rx.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = this.gridNotice.Rows.Add();
            this.gridNotice.Rows[n].Cells[0].Value = this.cmbNotice.Text;
        }
    }
}
