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
    public partial class VaccinationViewerfrm : Form
    {
        public VaccinationViewerfrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void VaccinationViewerfrm_Load(object sender, EventArgs e)
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
            this.txtanimalbreed.Text = val.Pet_breed;
            this.txtallergies.Text = val.Pet_skinallergies;
            this.cmbOperations.Text = val.Operation;

            this.txt1stboostdistemper.Text = val.First_boost_distemper;
            this.Date1stboostdistemper.Text = val.First_date_distemper;

            this.txt2ndboostdistemper.Text = val.Second_boost_distemper;
            this.date2ndboostfeline.Text = val.Second_date_distemper;

            this.txt3rdboostdistemper.Text = val.Third_boost_distemper;
            this.Date3rdboostdistemper.Text = val.Third_date_distemper;

            this.txt1stboostfeline.Text = val.First_boost_feline;
            this.Date1stboostfeline.Text = val.First_date_feline;

            this.txt2ndboostfeline.Text = val.Third_boost_distemper;
            this.date2ndboostfeline.Text = val.Third_date_distemper;

            this.txt1stboostrabies.Text = val.First_boost_rabies;
            this.date1stboostrabies.Text = val.First_date_rabies;
        }

        private void btnSaveVax_Click(object sender, EventArgs e)
        {
            VaccinationUpdatefrm vaxup = new VaccinationUpdatefrm();
            vaxup.Show();
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
    }
}
