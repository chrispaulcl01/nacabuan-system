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
    public partial class Consultationfrm : Form
    {
        public Consultationfrm()
        {
            InitializeComponent();
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void Consultationfrm_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPatientName.Text = val.Pet_name;
            this.txtContactNo.Text = val.Contactno;
            this.cmbGender.Text = val.Pet_gender;
            this.bdayDatepicker.Text = val.Pet_bday;
            this.txtAge.Text = val.Pet_age;
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.txtAnimalBreed.Text = val.Pet_breed;
        }

        private void cmbAnimalBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                MessageBox.Show("Temperature is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtExistingConditions.Text))
            {
                MessageBox.Show("Exsisting Condition is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAllergies.Text))
            {
                MessageBox.Show("Allergies is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtTypeOfVaccine.Text))
            {
                MessageBox.Show("Type of vaccine is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Weight is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtQuestion.Text))
            {
                MessageBox.Show("Question is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbStool.Text))
            {
                MessageBox.Show("Stool is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbBehaAtti.Text))
            {
                MessageBox.Show("Behavior Attetute is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbAppetite.Text))
            {
                MessageBox.Show("Appetite is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbDrinkingwater.Text))
            {
                MessageBox.Show("Drink Water is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbDiagnosis.Text))
            {
                MessageBox.Show("Diagnosis is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            else 
            {
                if (patient.Savedpatient(this.txtPetID.Text, this.txtOwnersName.Text, this.txtPatientName.Text, this.txtAge.Text,
                this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.txtAnimalBreed.Text, this.txtContactNo.Text,
                double.Parse(this.txtTemperature.Text), DateTime.Parse(this.dateLastvaccinedate.Text), this.txtExistingConditions.Text,
                this.txtAllergies.Text, this.txtTypeOfVaccine.Text, double.Parse(this.txtWeight.Text), this.txtQuestion.Text, this.cmbStool.Text,
                this.cmbBehaAtti.Text, this.cmbAppetite.Text, this.cmbDrinkingwater.Text, this.cmbDiagnosis.Text))
                {
                    for (int i = 0; i < this.gridNotice.Rows.Count - 1; i++)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(con.conString()))
                            {
                                string sql = @"INSERT INTO dss_database.add_notice(pet_id, notice)
                                                                                                   VALUES(@pet_id, @notice);";
                                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                                {
                                    cmd.Parameters.AddWithValue("@pet_id", this.txtPetID.Text);
                                    cmd.Parameters.AddWithValue("@notice", this.gridNotice.Rows[i].Cells[0].Value);

                                    connection.Open();
                                    cmd.ExecuteReader();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error adding symptoms: " + ex.ToString());
                        }
                        MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        patient.DeletePatientlist(this.txtPetID.Text);

                        if(patient.PatientInfoViewer(this.txtPetID.Text))
                        {
                            this.Close();

                            frmRX rx = new frmRX();
                            rx.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to Saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btnPConsultExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Home"].Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = this.gridNotice.Rows.Add();
            this.gridNotice.Rows[n].Cells[0].Value = this.cmbNotice.Text;
        }

        private void cmbAnimalSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
