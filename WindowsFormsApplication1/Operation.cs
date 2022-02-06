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
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnPregnacy_Click(object sender, EventArgs e)
        {
            PregnancyCesarean preg = new PregnancyCesarean();
            preg.Show();
        }

        private void btnEyeOP_Click(object sender, EventArgs e)
        {
            EyeOperation eye = new EyeOperation();
            eye.Show();
        }

        private void btnEarsOP_Click(object sender, EventArgs e)
        {
            EarOperation ear = new EarOperation();
            ear.Show();
        }

        private void btnMammaryOP_Click(object sender, EventArgs e)
        {
            MammaryOperation mam = new MammaryOperation();
            mam.Show();
        }

        private void btnCrastration_Click(object sender, EventArgs e)
        {
            Crastration cras = new Crastration();
            cras.Show();
        }

        private void btnLygaeide_Click(object sender, EventArgs e)
        {
            Lygaeidae ly = new Lygaeidae();
            ly.Show();
        }
    }
}
