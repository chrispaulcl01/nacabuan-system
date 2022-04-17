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
    public partial class DewormingUpdatefrm : Form
    {
        public DewormingUpdatefrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void DewormingUpdatefrm_Load(object sender, EventArgs e)
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
            this.cmbOperation.Text = val.Operation;

            this.Dewormdate2weeks.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine2weeks.Text = val.Deworn_2weeks_medicine;

            this.Dewormdate4weeks.Text = val.Deworn_4weeks_date;
            this.txtDewormMedicine4weeks.Text = val.Deworn_4weeks_medicine;

            this.Dewormdate6weeks.Text = val.Deworn_6weeks_date;
            this.txtDewormMedicine6weeks.Text = val.Deworn_6weeks_medicine;

            this.Dewormdate8weeks.Text = val.Deworn_8weeks_date;
            this.txtDewormMedicine8weeks.Text = val.Deworn_8weeks_medicine;

            this.Dewormdate10weeks.Text = val.Deworn_10weeks_date;
            this.txtDewormMedicine10weeks.Text = val.Deworn_10weeks_medicine;

            this.Dewormdate12weeks.Text = val.Deworn_12weeks_date;
            this.txtDewormMedicine12weeks.Text = val.Deworn_12weeks_medicine;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnBackDewarm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDewarm_Click(object sender, EventArgs e)
        {
            if (patient.UpdateDewormPatient(this.txtPetID.Text, this.txtOwnersName.Text, this.txtPhoneNumber.Text, this.txtAddress.Text, this.txtPatientName.Text,
                int.Parse(this.txtAge.Text), this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.cmbAnimalBreed.Text,
                this.cmbOperation.Text, this.Dewormdate2weeks.Text, this.txtDewormMedicine2weeks.Text, this.Dewormdate4weeks.Text, this.txtDewormMedicine4weeks.Text, this.Dewormdate6weeks.Text, this.txtDewormMedicine6weeks.Text,
                 this. Dewormdate8weeks.Text, this.txtDewormMedicine8weeks.Text, this.Dewormdate10weeks.Text, this.txtDewormMedicine10weeks.Text, this.Dewormdate12weeks.Text, this.txtDewormMedicine12weeks.Text))
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

        private void cmbAnimalSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnimalSpecies.Text == "DOG")
            {
                cmbAnimalBreed.Items.Clear();
                List<string> dog = new List<string>()


{
                "Labrador", "Affenpinscher", "Akita", "American Eskimo Dog", "American Staffordshire Terrier", "Bearded Collie", "Belgian Malinois",
                "Bichon Frise", "Border Collie", "German Shepherd", "Pomeranian", "Labrador Retriever", "Bulldog", "Golden Retriever", "Chow Chow", "Pug,Siberian Husky",
                "Poodle", "Border Collie", "Pembroke Welsh Corgi"
                };

                for (int i = 0; i < dog.Count; i++)
                {
                    cmbAnimalBreed.Items.Add(dog[i]);
                }
            }

            else if (cmbAnimalSpecies.Text == "CAT")
            {
                cmbAnimalBreed.Items.Clear();
                List<string> cat = new List<string>()
{

                "Persian cat", "Maine Coon", "British Shorthair", "Sphynx cat", "Ragdollr", "Norwegian Forest cat", "Siberian cat",
                "Exotic Shorthair", "Russian Blue", "European shorthair", "Birman", "Balinese cat", "Thai cat", "American Bobtail"
                };

                for (int i = 0; i < cat.Count; i++)
                {
                    cmbAnimalBreed.Items.Add(cat[i]);
                }
            }

            else
            {
                cmbAnimalBreed.Items.Clear();
                List<string> bird = new List<string>()
{

                "Canary", "Cockatiel", "Goldie's Lorikeet", "LoveBird ", "Pacific Parrotlet", "White-Crowned Parrot", "Zebra Finch"
                };

                for (int i = 0; i < bird.Count; i++)
                {
                    cmbAnimalBreed.Items.Add(bird[i]);
                }
            }
        }
    }
}
