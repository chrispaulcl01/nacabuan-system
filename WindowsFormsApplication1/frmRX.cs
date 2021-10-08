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
    public partial class frmRX : Form
    {
        public frmRX()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void frmRX_Load(object sender, EventArgs e)
        {
            this.txtID.Text = val.PetID;
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveRX_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtEditor.Text))
            {
                MessageBox.Show("Owner name is missing!, Add Prescription", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (patient.PrescriptionRx(this.txtID.Text, val.OwnersName, val.Patientname, this.txtEditor.Text))
                {
                    MessageBox.Show("Prescription Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error! Saved Prescription", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PaymentTransactfrm payfrm = new PaymentTransactfrm();
                payfrm.Show();
                Application.OpenForms["frmRX"].Hide();
                Application.OpenForms["Home"].Hide();
            }   
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.txtRXprinted.Clear();
            this.txtRXprinted.Text += "             Infrmation System for Pet Diagnosis";
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "              Roxas City Capiz Philippines 5800";
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "***********************************************************";
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "Ownner Name: " + val.OwnersName;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "Patient Name: " + val.Patientname;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "Date: " + DateTime.Now.ToString("MM/dd/yyyy");
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "Time: " + DateTime.Now.ToString("hh:mm tt");
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "Prescription: ";
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += txtEditor.Text;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "                      ---------------------------------------------------";
            this.txtRXprinted.Text += Environment.NewLine;
            this.txtRXprinted.Text += "                          Doctor signature over printed name";
        }
    }
}
