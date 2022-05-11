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

            this.rprtReportTable.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pTotalSalesOfTheDay", val.TotalSalesToday));
            parameters.Add(new ReportParameter("pTotalSalesOfTheMonth", val.TotalSalesMonth));
            parameters.Add(new ReportParameter("pTotalSalesOfTheYear", val.TotalSalesYear));
            parameters.Add(new ReportParameter("pTotalPatientsCats", val.Totalpcats));;
            parameters.Add(new ReportParameter("pTotalPatientsDogs", val.Totalpdogs));
            parameters.Add(new ReportParameter("pTotalPatientsBirds", val.Totalpbird));
            parameters.Add(new ReportParameter("pTotalPatients", val.Totalpatientss));
            parameters.Add(new ReportParameter("pDate", val.ReportDate.ToString()));
            this.rprtReportTable.LocalReport.SetParameters(parameters);
            this.rprtReportTable.RefreshReport();
        }
        
        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
