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
    public partial class VaccinationUpdatefrm : Form
    {
        public VaccinationUpdatefrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void btnSaveVax_Click(object sender, EventArgs e)
        {
            if (patient.UpdatePatientVaccine(txtPetID.Text, txtOwnersName.Text, txtPhoneNum.Text, txtAddress.Text, txtPatientName.Text,
               txtAge.Text, cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
               cmbAllergies.Text, Vaccinedatetimepicker.Value.Date, cmbOperations.Text,
               txt1stboostdistemper.Text, Date1stboostdistemper.Value.Date, txt2ndboostdistemper.Text, Date2ndboostdistemper.Value.Date,
               txt3rdboostdistemper.Text, Date3rdboostdistemper.Value.Date, txt1stboostfeline.Text, Date1stboostfeline.Value.Date, txt2ndboostfeline.Text, date2ndboostfeline.Value.Date,
               txt1stboostrabies.Text, date1stboostrabies.Value.Date
               ))
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

        private void btnBackVax_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VaccinationUpdatefrm_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPhoneNum.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbGender.Text = val.Pet_gender;
            this.bdayDatepicker.Text = val.Pet_bday;
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.cmbAnimalBreed.Text = val.Pet_breed;
            this.cmbAllergies.Text = val.Pet_skinallergies;
            this.cmbOperations.Text = val.Operation;

            this.txt1stboostdistemper.Text = val.First_boost_distemper;
            this.Date1stboostdistemper.Value = val.First_date_distemper;

            this.txt2ndboostdistemper.Text = val.Second_boost_distemper;
            this.Date2ndboostdistemper.Value = val.Second_date_distemper;

            this.txt3rdboostdistemper.Text = val.Third_boost_distemper;
            this.Date3rdboostdistemper.Value = val.Third_date_distemper;

            this.txt1stboostfeline.Text = val.First_boost_feline;
            this.Date1stboostfeline.Value = val.First_date_feline;

            this.txt2ndboostfeline.Text = val.Third_boost_distemper;
            this.date2ndboostfeline.Value = val.Third_date_distemper;

            this.txt1stboostrabies.Text = val.First_boost_rabies;
            this.date1stboostrabies.Value = val.First_date_rabies;
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

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPetID.Text))
            {
                MessageBox.Show("Pet ID is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (String.IsNullOrWhiteSpace(txtOwnersName.Text))
            {
                MessageBox.Show("Owners name is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtPhoneNum.Text))
            {
                MessageBox.Show("Phone number is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show("Patient name is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Pet age is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Pet gender is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cmbAnimalSpecies.Text))
            {
                MessageBox.Show("Animal spiecies is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cmbAnimalBreed.Text))
            {
                MessageBox.Show("Animal breed is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cmbAllergies.Text))
            {
                MessageBox.Show("Allergies is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cmbOperations.Text))
            {
                MessageBox.Show("Operation is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt1stboostdistemper.Text))
            {
                MessageBox.Show("1stBooster distemper is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt2ndboostdistemper.Text))
            {
                MessageBox.Show("2ndBooster distemper is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt3rdboostdistemper.Text))
            {
                MessageBox.Show("3rdBooster distemper is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt1stboostfeline.Text))
            {
                MessageBox.Show("1stBoost feline is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt2ndboostfeline.Text))
            {
                MessageBox.Show("2ndBoost feline is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt1stboostrabies.Text))
            {
                MessageBox.Show("1st Rabbies is empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (patient.UpdatePatientVaccine(txtPetID.Text, txtOwnersName.Text, txtPhoneNum.Text, txtAddress.Text, txtPatientName.Text,
               txtAge.Text, cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
               cmbAllergies.Text, Vaccinedatetimepicker.Value.Date, cmbOperations.Text,
               txt1stboostdistemper.Text, Date1stboostdistemper.Value.Date, txt2ndboostdistemper.Text, Date2ndboostdistemper.Value.Date,
               txt3rdboostdistemper.Text, Date3rdboostdistemper.Value.Date, txt1stboostfeline.Text, Date1stboostfeline.Value.Date, txt2ndboostfeline.Text, date2ndboostfeline.Value.Date,
               txt1stboostrabies.Text, date1stboostrabies.Value.Date
               ))
            {

                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //patient.DeleteSkinPatientData(this.txtPetID.Text);
                this.Close();

            }
            else
            {
                MessageBox.Show("Failed to Saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
