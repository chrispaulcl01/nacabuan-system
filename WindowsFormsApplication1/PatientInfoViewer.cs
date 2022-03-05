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
    public partial class PatientInfoViewer : Form
    {
        public PatientInfoViewer()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void PatientInfoViewer_Load(object sender, EventArgs e)
        {
            //this.txtPetID.Text = val.PetID;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPatientName.Text = val.Pet_name;
            this.txtContactNo.Text = val.Contactno;
            this.cmbGender.Text = val.Pet_gender;
            //this.bdayDatepicker.Text = val.Pet_bday;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.txtAnimalBreed.Text = val.Pet_breed;
            this.txtTemperature.Text = val.Temp.ToString();
            this.dateLastvaccinedate.Text = val.lastvacinedate.ToString();
            this.txtExistingConditions.Text = val.Exsist_con;
           // this.txtAllergies.Text = val.Allergies;
            this.txtTypeOfVaccine.Text = val.Type_vaccine;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.txtQuestion.Text = val.Question;
            this.cmbStool.Text = val.Stool;
            this.cmbBehaAtti.Text = val.Behav_att;
            this.cmbAppetite.Text = val.Appetite;
            this.cmbDrinkingwater.Text = val.Drink;
            this.gridnoticeviewer.Text = val.Notice;
            this.txtDiagnosis.Text = val.Diagnosis;
            patient.PatientInfoViewerNotice(val.Pet_id, gridnoticeviewer);
        }

        private void btnPConsultExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            

        }

        private void btnrxhistory_Click(object sender, EventArgs e)
        {
            if (patient.ViewRXHistory(this.txtPetID.Text))
            {
                Rxviewer rxv = new Rxviewer();
                rxv.Show();
            }
        }
    }
}
