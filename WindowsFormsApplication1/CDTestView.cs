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
    public partial class CDTestView : Form
    {
        public CDTestView()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void CDTestView_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPhoneNumber.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbGender.Text = val.Pet_gender;
            this.txtPetBday.Text = val.Pet_bday;
            this.txtPetSpecies.Text = val.Pet_species;
            this.txtPetBreed.Text = val.Pet_breed;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.txtPetSkinnAllergies.Text = val.Pet_skinallergies;
            this.txtExistDisease.Text = val.Pet_existdisease;
            this.txtTestKitResult.Text = val.Testkit;
            this.txtService.Text = val.Operation;
            this.DateOperation.Value = val.Op_date;
            this.txtOpTime.Text = val.Op_time.ToString();
        }

        private void btnBackPreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CDTestUpgrade cdtup = new CDTestUpgrade();
            cdtup.Show();   
        }
    }
}
