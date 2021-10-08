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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridTransacHistoty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            patient.TransactionViewer(gridTransacHistory);
        }
    }
}

