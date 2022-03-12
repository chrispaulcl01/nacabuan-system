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
    public partial class DewormingView : Form
    {
        public DewormingView()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void DewormingView_Load(object sender, EventArgs e)
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
            this.txtService.Text = val.Operation;

            this.txtDeworm2weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine2weeks.Text = val.Deworn_2weeks_medicine;

            this.txtDeworm4weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine4weeks.Text = val.Deworn_4weeks_medicine;

            this.txtDeworm6weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine6weeks.Text = val.Deworn_6weeks_medicine;

            this.txtDeworm8weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine8weeks.Text = val.Deworn_8weeks_medicine;

            this.txtDeworm10weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine10weeks.Text = val.Deworn_10weeks_medicine;

            this.txtDeworm12weeksDate.Text = val.Deworn_2weeks_date;
            this.txtDewormMedicine12weeks.Text = val.Deworn_12weeks_medicine;
        }

        private void btnBackDewarm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
