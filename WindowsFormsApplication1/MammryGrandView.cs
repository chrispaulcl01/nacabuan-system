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
    public partial class MammryGrandView : Form
    {
        public MammryGrandView()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void MammryGrandView_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPhoneNumber.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.txtPetGender.Text = val.Pet_gender;
            this.txtBday.Text = val.Pet_bday;
            this.txtPetSpecies.Text = val.Pet_species;
            this.txtPetBreed.Text = val.Pet_breed;
            this.txtWeight.Text = val.Pet_weight;
            this.txtPetSkinnAllergies.Text = val.Pet_skinallergies;
            this.txtExistDiesease.Text = val.Pet_existdisease;
            this.txtOperation.Text = val.Operation;
            this.txtTypevax.Text = val.Typevax;
            this.VaxDate.Value = val.Vaxdate;

            this.txtResultSuperchen.Text = val.Superchen;
            this.txtResultTotalprotein.Text = val.Totalprotein;
            this.txtResultAlbumin.Text = val.Albumin;
            this.txtResultGlobulin.Text = val.Globulin;
        }

        private void btnSavemammry_Click(object sender, EventArgs e)
        {
            MammaryUpdatefrm mamup = new MammaryUpdatefrm();
            mamup.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
