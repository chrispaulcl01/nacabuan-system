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
    public partial class Rxviewer : Form
    {
        public Rxviewer()
        {
            InitializeComponent();
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void txtRXHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rxviewer_Load(object sender, EventArgs e)
        {
            DateTime date = val.Datee;

            this.txtRXHistory.Clear();
            this.txtRXHistory.Text += "             Infrmation System for PEt Diagnosis";
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "              Roxas City Capiz Philippines 5800";
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "***********************************************************";
            this.txtRXHistory.Text += "Pet ID: " + val.PetID;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "Ownner Name: " + val.OwnersName;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "Patient Name: " + val.Patientname;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "Date: " + date.ToString("MM/dd/yy");
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "Prescription: ";
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += val.Prescription;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "                      ---------------------------------------------------";
            this.txtRXHistory.Text += Environment.NewLine;
            this.txtRXHistory.Text += "                          Doctor signature over printed name";

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
