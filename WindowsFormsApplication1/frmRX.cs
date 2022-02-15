using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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
            this.txtID.Text = val.Pet_id;
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
                if (patient.PrescriptionRx(this.txtID.Text, val.OwnersName, val.Pet_name, this.txtEditor.Text))
                {
                    MessageBox.Show("Prescription Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PaymentTransactfrm payfrm = new PaymentTransactfrm();
                    payfrm.Show();
                    Application.OpenForms["frmRX"].Hide();
                    Application.OpenForms["Home"].Hide();
                }
                else
                {
                    MessageBox.Show("Error! Saved Prescription", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.rprtRX.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("rpPetID", txtID.Text));
            parameters.Add(new ReportParameter("rpDate", DateTime.Now.ToString("MM/dd/y")));
            parameters.Add(new ReportParameter("rpOwnersName", val.OwnersName));
            parameters.Add(new ReportParameter("rpPatientName", val.Pet_name));
            parameters.Add(new ReportParameter("rpPrescription", txtEditor.Text));

            this.rprtRX.LocalReport.SetParameters(parameters);
            this.rprtRX.RefreshReport();
        }

        private void btnPConsultExit_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}
