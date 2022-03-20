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
    public partial class PregrancyCesareanView : Form
    {
        public PregrancyCesareanView()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void Pregrancy_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersname.Text = val.OwnersName;
            this.txtPhoneNumber.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.txtPetGender.Text = val.Pet_gender;
            this.txtBday.Text = val.Pet_bday;
            this.txtPetSpecies.Text = val.Pet_species;
            this.txtPetBreed.Text = val.Pet_breed;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.txtPetAllergies.Text = val.Pet_skinallergies;
            this.txtExDisease.Text = val.Pet_existdisease;
            this.txtOperation.Text = val.Operation;
            this.txtOpDate.Text = val.Op_date.ToString();
            this.txtOpTime.Text = val.Op_time;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnBackPreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePreg_Click(object sender, EventArgs e)
        {
            PregnancyCesarianUpdate pregupd = new PregnancyCesarianUpdate();
            pregupd.Show();
        }
    }
}
