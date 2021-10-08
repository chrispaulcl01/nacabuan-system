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
            this.txtPetID.Text = val.PetID;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPatientName.Text = val.Patientname;
            this.txtContactNo.Text = val.Contactno;
            this.cmbGender.Text = val.Gender;
            this.bdayDatepicker.Text = val.Birthday;
            this.txtAge.Text = val.Age.ToString();
            this.cmbAnimalSpecies.Text = val.Animalspecies;
            this.txtAnimalBreed.Text = val.Animalbreed;
            this.txtTemperature.Text = val.Temp.ToString();
            this.dateLastvaccinedate.Text = val.lastvacinedate.ToString();
            this.txtExistingConditions.Text = val.Exsist_con;
            this.txtAllergies.Text = val.Allergies;
            this.txtTypeOfVaccine.Text = val.Type_vaccine;
            this.txtWeight.Text = val.Weight.ToString();
            this.txtQuestion.Text = val.Question;
            this.cmbStool.Text = val.Stool;
            this.cmbBehaAtti.Text = val.Behav_att;
            this.cmbAppetite.Text = val.Appetite;
            this.cmbDrinkingwater.Text = val.Drink;
            this.gridnoticeviewer.Text = val.Notice;
            this.txtDiagnosis.Text = val.Diagnosis;
            patient.PatientInfoViewerNotice(val.PetID, gridnoticeviewer);
        }

        private void btnPConsultExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (patient.PatientInfoViewer(this.txtPetID.Text))
            {
                PatientListEditor pleditor = new PatientListEditor();
                pleditor.Show();
                this.Hide();
            }

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
