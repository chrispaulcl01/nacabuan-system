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
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersname.Text = val.OwnersName;
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
            this.cmbAllergies.Text = val.Pet_existdisease;
            this.cmbOperations.Text = val.Operation;
            this.DateOperetion.Value = val.Op_date;
            this.txtOpTime.Text = val.Op_time.ToString();
        }

        private void btnSaveCrast_Click(object sender, EventArgs e)
        {
            if (patient.UpdateCrastrationOpPatient(this.txtPetID.Text, this.txtOwnersname.Text, this.txtPhoneNumber.Text, this.txtAddress.Text, this.txtPatientName.Text,
                this.txtAge.Text, this.cmbGender.Text, this.bdayDatepicker.Text, this.cmbAnimalSpecies.Text, this.cmbAnimalBreed.Text, this.txtWeight.Text,
                this.cmbAllergies.Text, this.txtExDisease.Text, this.cmbOperations.Text, this.DateOperetion.Value.Date, this.txtOpTime.Text))
            {

                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //patient.DeleteSkinPatientData(this.txtPetID.Text);

            }
            else
            {
                MessageBox.Show("Failed to Saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmRX rx = new frmRX();
            rx.Show();
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
