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
    public partial class ReportTable : Form
    {
        public ReportTable()
        {
            InitializeComponent();
        }
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void ReportTable_Load(object sender, EventArgs e)
        {
            this.txtPReports.Clear();
            this.txtPReports.Text += "Total Sales of Today";
            this.txtPReports.Text += Environment.NewLine;
            this.txtPReports.Text += Environment.NewLine;
            this.txtPReports.Text += val.TotalSalesToday + "                                                    " + val.TotalSalesMonth + "                                 " + val.TotalSalesYear;

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
