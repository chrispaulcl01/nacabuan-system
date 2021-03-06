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

        public void autoGenNum()
        {
            string num = "1234567890";
            int len = num.Length;
            string otp = "";
            int otpdigit = 6;
            string finaldigit;

            int getIndex;

            for (int i = 0; i < otpdigit; ++i)
            {
                do
                {
                    getIndex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getIndex].ToString();
                }

                while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }

            this.txtPetID.Text = ("#" + otp);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSaveDewarm_Click(object sender, EventArgs e)
        {
            if (patient.SaveDewormedPatient(txtPetID.Text, txtOwnersName.Text, txtPhoneNumber.Text, txtAddress.Text, txtPatientName.Text,
                txtAge.Text, cmbGender.Text, bdayDatepicker.Value.Date, cmbAnimalSpecies.Text, cmbAnimalBreed.Text,
                cmbOperation.Text, Dewormdatetimepicker.Value.Date, Dewormdate2weeks.Value.Date, txtDewormMedicine2weeks.Text, Dewormdate4weeks.Value.Date, txtDewormMedicine4weeks.Text, Dewormdate6weeks.Value.Date, txtDewormMedicine6weeks.Text,
                 Dewormdate8weeks.Value.Date, txtDewormMedicine8weeks.Text, Dewormdate10weeks.Value.Date, txtDewormMedicine10weeks.Text, Dewormdate12weeks.Value.Date, txtDewormMedicine12weeks.Text)) 
            {
                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                val.Pet_id = this.txtPetID.Text;
                val.OwnersName = this.txtOwnersName.Text;
                val.Pet_name = this.txtPatientName.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnBackDewarm_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Deworming"].Close();
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

        private void Deworming_Load(object sender, EventArgs e)
        {
            autoGenNum();
        }
    }
}
