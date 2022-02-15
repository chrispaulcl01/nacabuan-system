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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Dashboard home = new functions.Dashboard();

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
        

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            this.richPrescriptions.Clear();
            this.richPrescriptions.Text += "Pet ID:" + val.Pet_id;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "***************************************";
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "     PATIENT INFORMATION SYSTEM";
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "***************************************";
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "Owner Name:" + val.OwnersName;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "Patient Name:" + val.Pet_name;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "Animal Species:" + val.Pet_species;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "Prescription:";
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += Environment.NewLine;
            this.richPrescriptions.Text += "                                                 Signature";
        }
    }
}
