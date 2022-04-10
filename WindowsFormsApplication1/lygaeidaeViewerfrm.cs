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
    public partial class lygaeidaeViewerfrm : Form
    {
        public lygaeidaeViewerfrm()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void btnSaveLy_Click(object sender, EventArgs e)
        {
            LygaeidaeUpdatefrm lyup = new LygaeidaeUpdatefrm();
            lyup.Show();
        }

        private void btnBackLyg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lygaeidaeViewerfrm_Load(object sender, EventArgs e)
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
            this.txtExDisease.Text = val.Pet_existdisease;
            this.cmbOperations.Text = val.Operation;
            this.DateOperetion.Text = val.Op_date.ToString();
            this.txtOpTime.Text = val.Op_time;
        }
    }
}
