﻿using System;
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
    public partial class SkinTreatmentUpdate : Form
    {
        public SkinTreatmentUpdate()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void SkinTreatmentUpdate_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.Pet_id;
            this.txtOwnersName.Text = val.OwnersName;
            this.txtPhoneNumber.Text = val.Phone_num;
            this.txtAddress.Text = val.Address;
            this.txtPatientName.Text = val.Pet_name;
            this.txtAge.Text = val.Pet_age.ToString();
            this.cmbGender.Text = val.Pet_gender;
            this.bdayDatepicker.Value = val.Op_date;
            this.cmbAnimalSpecies.Text = val.Pet_species;
            this.cmbAnimalBreed.Text = val.Pet_breed;
            this.txtWeight.Text = val.Pet_weight.ToString();
            this.cmbSkinAllergies.Text = val.Pet_skinallergies;
            this.txtExistDisease.Text = val.Pet_existdisease;
            this.cmbOperations.Text = val.Operation;
            this.DateOperation.Value = val.Op_date;
            this.txtOpTime.Text = val.Op_time.ToString();
            
           
        }

        private void btnBackPreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
