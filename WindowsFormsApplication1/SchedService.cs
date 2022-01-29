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
    public partial class SchedService : Form
    {
        public SchedService()
        {
            InitializeComponent();
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            Vaccination vax = new Vaccination();
            vax.Show();
        }

        private void btnCrastration_Click(object sender, EventArgs e)
        {
            Crastration crast = new Crastration(); 
            crast.Show();  
        }

        private void btnLygaeide_Click(object sender, EventArgs e)
        {
            Lygaeidae ly = new Lygaeidae(); 
            ly.Show();
        }
    }
}
