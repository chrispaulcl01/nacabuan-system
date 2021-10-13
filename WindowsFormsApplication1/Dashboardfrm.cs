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
    public partial class Dashboardfrm : Form
    {
        public Dashboardfrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Dashboard dashboard = new functions.Dashboard();
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

        private void Home_Load(object sender, EventArgs e)
        {
            autoGenNum();
            this.txtOwnersName.Text = val.OwnersName;
            this.cmbAnimalSpecies.Text = val.Pettype;
            this.txtContactNo.Text = val.Contactno;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrWhiteSpace(this.txtOwnersName.Text))
            {
                MessageBox.Show("Owner name is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtPatientName.Text))
            {
                MessageBox.Show("Patient name is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (dashboard.AddData(txtPetID.Text, txtOwnersName.Text, txtPatientName.Text, txtContactNo.Text, cmbGender.Text, bdayDatepicker.Text, txtAge.Text, cmbAnimalSpecies.Text, cmbAnimalBreed.Text, DateTime.Parse(dateSchedPicker.Value.ToString())))
                {
                    MessageBox.Show("Schedule has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtOwnersName.ResetText();
                    this.txtPatientName.ResetText();
                    this.txtContactNo.ResetText();
                    this.txtAge.ResetText();
                    this.cmbGender.ResetText();
                    this.bdayDatepicker.ResetText();
                    this.cmbAnimalSpecies.ResetText();
                    this.cmbAnimalBreed.ResetText();
                }
                else
                {
                    MessageBox.Show("Error! unfilled data", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
            
        }

        private void cmbAnimalSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtTemperature_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void txtAllergies_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtExistingConditions_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void txtLastVaccineDate_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestion_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTypeOfVaccine_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnimalSpecies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.cmbAnimalSpecies.Text == "DOG")
            {
                this.cmbAnimalBreed.Items.Clear();
                this.cmbAnimalBreed.Items.AddRange(new string[] { "Askal", "Labrador", "German Shepherd " });
            }
            else if (this.cmbAnimalSpecies.Text == "CATS")
            {
                this.cmbAnimalBreed.Items.Clear();
                this.cmbAnimalBreed.Items.AddRange(new string[] { "Persian cat", "British Shorthair", "Japanese Bobtail" });
            }
            else
            {
                this.cmbAnimalBreed.Items.Clear();
                this.cmbAnimalBreed.Items.AddRange(new string[] { "Bourke's Parrot Budgie.", "Goldie's Lorikeet. Lovebird.", "Monk Parakeet. Pacific Parrotlet." });
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtOwnersName.Text))
            {
                MessageBox.Show("Owner name is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtPatientName.Text))
            {
                MessageBox.Show("Patient name is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is missing!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dashboard.AddData(txtPetID.Text, txtOwnersName.Text, txtPatientName.Text, txtContactNo.Text, cmbGender.Text, bdayDatepicker.Text, txtAge.Text, cmbAnimalSpecies.Text, cmbAnimalBreed.Text, DateTime.Parse(dateSchedPicker.Value.ToString())))
                {
                    MessageBox.Show("Schedule has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtOwnersName.ResetText();
                    this.txtPatientName.ResetText();
                    this.txtContactNo.ResetText();
                    this.txtAge.ResetText();
                    this.cmbGender.ResetText();
                    this.bdayDatepicker.ResetText();
                    this.cmbAnimalSpecies.ResetText();
                    this.cmbAnimalBreed.ResetText();
                }
                else
                {
                    MessageBox.Show("Error! unfilled data", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbAnimalBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
