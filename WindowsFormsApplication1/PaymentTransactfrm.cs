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
    public partial class PaymentTransactfrm : Form
    {
        public PaymentTransactfrm()
        {
            InitializeComponent();
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void PaymentTransactfrm_Load(object sender, EventArgs e)
        {
            this.txtPetID.Text = val.PetID;
            this.txtPatientName.Text = val.Patientname;
            this.txtOwnersName.Text = val.OwnersName;
            this.rvReciept.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtTotalAmountfee.Text))
            {
                MessageBox.Show("Total Amount Fee is Empty!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmountpay.Text))
            {
                MessageBox.Show("Amount Pay is Empty!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double calculate = (double.Parse(txtAmountpay.Text) - double.Parse(txtTotalAmountfee.Text));
                this.txtChange.Text = calculate.ToString();
            }

            this.rvReciept.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("rpPetID", val.PetID));
            parameters.Add(new ReportParameter("rpDate", val.Date));
            parameters.Add(new ReportParameter("rpOwnersNmae", val.OwnersName));
            parameters.Add(new ReportParameter("rpPatientName", val.Patientname.ToString()));
            parameters.Add(new ReportParameter("rpTotalAmountFee", txtTotalAmountfee.ToString()));
            parameters.Add(new ReportParameter("rpTotalAmountPay", txtAmountpay.ToString()));
            parameters.Add(new ReportParameter("rpChange", txtChange.ToString()));
            this.rvReciept.LocalReport.SetParameters(parameters);
            this.rvReciept.RefreshReport();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtTotalAmountfee.Text))
            {
                MessageBox.Show("Total Amount Fee is Empty!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmountpay.Text))
            {
                MessageBox.Show("Amount Pay is Empty!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtChange.Text))
            {
                MessageBox.Show("Change is Empty!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (patient.Reciept(this.txtPetID.Text, val.OwnersName, val.Patientname, this.txtTotalAmountfee.Text, this.txtAmountpay.Text, 
                    this.txtChange.Text))
                {
                    MessageBox.Show("Reciept Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home home = new Home();
                    home.Show();
                    Application.OpenForms["PaymentTransactfrm"].Hide();
                }
                else
                {
                    MessageBox.Show("Error! Saved Reciept", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
