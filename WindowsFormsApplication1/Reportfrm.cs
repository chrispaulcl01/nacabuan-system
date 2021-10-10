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
    public partial class btnPReport : Form
    {
        public btnPReport()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void Reportfrm_Load(object sender, EventArgs e)
        {
            this.ChartDatePick.Text = DateTime.Now.ToString("MM/dd/yy");

            patient.CountTotalPatientDog(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalDog.Text = val.Totaldogs.ToString();

            patient.CountTotalPatientCat(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalCat.Text = val.Totalcat.ToString();

            patient.CountTotalPatientBird(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalBird.Text = val.Totalbird.ToString();

            patient.TotalSalesToday(this.ChartDatePick.Text);
            this.txtTotalDay.Text = val.TotalSalesToday;

            patient.TotalSalesMonth(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalMonth.Text = val.TotalSalesMonth;

            patient.TotalSalesYear(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalYear.Text = val.TotalSalesYear;

            patient.Totalpatient(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalpatient.Text = val.Totalpatient.ToString();

            if (String.IsNullOrWhiteSpace(this.txtTotalDog.Text))
            {
                this.txtTotalDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalCat.Text))
            {
                this.txtTotalCat.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalBird.Text))
            {
                this.txtTotalBird.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalpatient.Text))
            {
                this.txtTotalpatient.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(this.txtTotalDay.Text))
            {
                this.txtTotalDay.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalMonth.Text))
            {
                this.txtTotalMonth.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalYear.Text))
            {
                this.txtTotalYear.Text = "0";
            }

            foreach (var series in ChartDog.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in ChartCat.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in ChartBird.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in ChartSales.Series)
            {
                series.Points.Clear();
            }

            this.ChartDog.Series[0].Points.AddXY("Total Dog of Month", this.txtTotalDog.Text.ToString());
            this.ChartCat.Series[0].Points.AddXY("Total Cat of Month", this.txtTotalCat.Text.ToString());
            this.ChartBird.Series[0].Points.AddXY("Total Bird of Month", this.txtTotalBird.Text.ToString());

            this.ChartSales.Series[0].Points.AddXY("Today", this.txtTotalDay.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Month", this.txtTotalMonth.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Year", this.txtTotalYear.Text.ToString());

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.ChartDatePick.Text = DateTime.Now.ToString("MM/dd/yy");

            patient.CountTotalPatientDog(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalDog.Text = val.Totaldogs.ToString();

            patient.CountTotalPatientCat(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalCat.Text = val.Totalcat.ToString();

            patient.CountTotalPatientBird(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalBird.Text = val.Totalbird.ToString();

            patient.TotalSalesToday(this.ChartDatePick.Text);
            this.txtTotalDay.Text = val.TotalSalesToday;

            patient.TotalSalesMonth(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalMonth.Text = val.TotalSalesMonth;

            patient.TotalSalesYear(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalYear.Text = val.TotalSalesYear;

            patient.Totalpatient(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalpatient.Text = val.Totalpatient.ToString();

            if (String.IsNullOrWhiteSpace(this.txtTotalDog.Text))
            {
                this.txtTotalDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalCat.Text))
            {
                this.txtTotalCat.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalBird.Text))
            {
                this.txtTotalBird.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalpatient.Text))
            {
                this.txtTotalpatient.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(this.txtTotalDay.Text))
            {
                this.txtTotalDay.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalMonth.Text))
            {
                this.txtTotalMonth.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtTotalYear.Text))
            {
                this.txtTotalYear.Text = "0";
            }

            foreach (var series in ChartDog.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in ChartCat.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in ChartBird.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in ChartSales.Series)
            {
                series.Points.Clear();
            }

            this.ChartDog.Series[0].Points.AddXY("Total Dog of Month", this.txtTotalDog.Text.ToString());
            this.ChartCat.Series[0].Points.AddXY("Total Cat of Month", this.txtTotalCat.Text.ToString());
            this.ChartBird.Series[0].Points.AddXY("Total Bird of Month", this.txtTotalBird.Text.ToString());

            this.ChartSales.Series[0].Points.AddXY("Today", this.txtTotalDay.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Month", this.txtTotalMonth.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Year", this.txtTotalYear.Text.ToString());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            val.TotalSalesToday = this.txtTotalDay.Text;
            val.TotalSalesMonth = this.txtTotalMonth.Text;
            val.TotalSalesYear = this.txtTotalYear.Text;
            val.Totalcat = int.Parse(this.txtTotalCat.Text);
            val.Totaldogs = int.Parse(this.txtTotalDog.Text);
            val.Totalbird = int.Parse(this.txtTotalBird.Text);
            val.Totalpatient = int.Parse(this.txtTotalpatient.Text);
            ReportTable rt = new ReportTable();
            rt.Show();
        }
    }
}
