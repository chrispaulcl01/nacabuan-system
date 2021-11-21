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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            Vaccination vac = new Vaccination();
            vac.Show();
        }

        private void btnSknTreat_Click(object sender, EventArgs e)
        {
            SkinTreatment skin = new SkinTreatment();
            skin.Show();
        }

        private void btnCPTest_Click(object sender, EventArgs e)
        {
            CPTest cp = new CPTest();
            cp.Show();
        }

        private void btnCDTest_Click(object sender, EventArgs e)
        {
            CDTest cd = new CDTest();
            cd.Show();
        }

        private void btnBloodTest_Click(object sender, EventArgs e)
        {
            BloodTest blood = new BloodTest();
            blood.Show();
        }

        private void btnDeworming_Click(object sender, EventArgs e)
        {
            Deworming deworm = new Deworming();
            deworm.Show();

        }
    }
}
