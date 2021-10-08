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
                this.txtReciept.Clear();
                this.txtReciept.Text += "     Information System for Pet Medical Diagnosis";
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "             Roxas City Capix Philippines 5800";
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "************************************************************";
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "                                    RECEIPT";
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "************************************************************";
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "Owners Name: " + val.OwnersName + "                     Date: " + DateTime.Now.ToString("MM/dd/yyyy");
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "Patient Name" + val.Patientname;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "Total Payment Fee:          P" + this.txtTotalAmountfee.Text;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "Total Amount Paid:           P" + this.txtAmountpay.Text;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += "Change:                             P" + this.txtChange.Text;
                this.txtReciept.Text += Environment.NewLine;
                this.txtReciept.Text += Environment.NewLine;
            }    
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
                if (patient.Reciept(this.txtPetID.Text, val.OwnersName, val.Patientname, this.txtTotalAmountfee.Text, this.txtAmountpay.Text, this.txtChange.Text))
                {
                    MessageBox.Show("Reciept Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error! Saved Reciept", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Home home = new Home();
                home.Show();
                Application.OpenForms["PaymentTransactfrm"].Hide();
            }
            
        }
    }
}
