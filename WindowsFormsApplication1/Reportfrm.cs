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

            patient.CountTotalSkinPatientDog();
            txtSkinDog.Text = val.Totaldogs.ToString();

            patient.CountTotalCDTPatientDog();
            txtCDTDog.Text = val.Totaldogs.ToString();

            patient.CountTotalCPTPatientDog();
            txtCPTDog.Text = val.Totaldogs.ToString();

            patient.CountTotalBloodPPatientDog();
            txtBloodDog.Text = val.Totaldogs.ToString();

            patient.CountTotalPregnancyPatientDog();
            txtPregDog.Text = val.Totaldogs.ToString();

            patient.CountTotalEyeOpPatientDog();
            txtEyeDog.Text = val.Totaldogs.ToString();

            patient.CountTotalEarOpPatientDog();
            txtEarDog.Text = val.Totaldogs.ToString();

            patient.CountTotalMammaryPatientDog();
            txtMammaryDog.Text = val.Totaldogs.ToString();

            patient.CountTotalVaccinePatientDog();
            txtVaxDog.Text = val.Totaldogs.ToString();

            patient.CountTotalCrastraionPatientDog();
            txtCrastDog.Text = val.Totaldogs.ToString();

            patient.CountTotalLygPatientDog();
            txtLyDog.Text = val.Totaldogs.ToString();

            patient.CountTotalDewormingPatientDog();
            txtDewormDog.Text = val.Totaldogs.ToString();


            patient.CountTotalSkinPatientCAT();
            txtSkinCat.Text = val.Totaldogs.ToString();

            patient.CountTotalCDTPatientCAT();
            txtCDTCat.Text = val.Totaldogs.ToString();

            patient.CountTotalCPTPatientCAT();
            txtCPTCat.Text = val.Totaldogs.ToString();

            patient.CountTotalBloodPPatientCAT();
            txtBloodCat.Text = val.Totaldogs.ToString();

            patient.CountTotalPregnancyPatientCAT();
            txtPregCat.Text = val.Totaldogs.ToString();

            patient.CountTotalEyeOpPatientCAT();
            txtEyeCat.Text = val.Totaldogs.ToString();

            patient.CountTotalEarOpPatientCAT();
            txtEarCat.Text = val.Totaldogs.ToString();

            patient.CountTotalMammaryPatientCAT();
            txtMammaryCat.Text = val.Totaldogs.ToString();

            patient.CountTotalVaccinePatientCAT();
            txtVaxCat.Text = val.Totaldogs.ToString();

            patient.CountTotalCrastraionPatientCAT();
            txtCrastCat.Text = val.Totaldogs.ToString();

            patient.CountTotalLygPatientCAT();
            txtLyCat.Text = val.Totaldogs.ToString();

            patient.CountTotalDewormingPatientCAT();
            txtDewormCat.Text = val.Totaldogs.ToString();


            patient.CountTotalSkinPatientBIRD();
            txtSkinBird.Text = val.Totaldogs.ToString();

            patient.CountTotalCDTPatientBIRD();
            txtCDTBird.Text = val.Totaldogs.ToString();

            patient.CountTotalCPTPatientBIRD();
            txtCPTBird.Text = val.Totaldogs.ToString();

            patient.CountTotalBloodPPatientBIRD();
            txtBloodBird.Text = val.Totaldogs.ToString();

            patient.CountTotalPregnancyPatientBIRD();
            txtPregBird.Text = val.Totaldogs.ToString();

            patient.CountTotalEyeOpPatientBIRD();
            txtEyeBird.Text = val.Totaldogs.ToString();

            patient.CountTotalEarOpPatientBIRD();
            txtEarBird.Text = val.Totaldogs.ToString();

            patient.CountTotalMammaryPatientBIRD();
            txtMammaryBird.Text = val.Totaldogs.ToString();

            patient.CountTotalVaccinePatientBIRD();
            txtVaxBird.Text = val.Totaldogs.ToString();

            patient.CountTotalCrastraionPatientBIRD();
            txtCrastBird.Text = val.Totaldogs.ToString();

            patient.CountTotalLygPatientBIRD();
            txtLyBird.Text = val.Totaldogs.ToString();

            patient.CountTotalDewormingPatientBIRD();
            txtDewormBird.Text = val.Totaldogs.ToString();

            //decimal a, b, c, d, f ;
            //a = decimal.Parse(txtSkinDog.Text);
            //b = decimal.Parse(txtCDTDog.Text);
            // c = decimal.Parse(txtCPTDog.Text);
            // d = decimal.Parse(txtBloodDog.Text);

            // txtTotalPatientDogs.Text = (a + b + c + d).ToString();

            
            



            double totalDogs = (double.Parse(txtSkinDog.Text) + double.Parse(txtCDTDog.Text) + double.Parse(txtCPTDog.Text) + double.Parse(txtBloodDog.Text)
            + double.Parse(txtPregDog.Text) + double.Parse(txtEyeDog.Text) + double.Parse(txtEarDog.Text)
            + double.Parse(txtMammaryDog.Text) + double.Parse(txtVaxDog.Text) + double.Parse(txtCrastDog.Text) + double.Parse(txtLyDog.Text) + double.Parse(txtDewormDog.Text));

            txtTotalPatientDogs.Text = totalDogs.ToString();

            double totalCats = (double.Parse(txtSkinCat.Text) + double.Parse(txtCDTCat.Text) + double.Parse(txtCPTCat.Text) + double.Parse(txtBloodCat.Text) + double.Parse(txtPregCat.Text) + double.Parse(txtEyeCat.Text) + double.Parse(txtEarCat.Text)
            + double.Parse(txtMammaryCat.Text) + double.Parse(txtVaxCat.Text) + double.Parse(txtCrastCat.Text) + double.Parse(txtLyCat.Text)
            + double.Parse(txtDewormCat.Text));

            txtTotalPatientCats.Text = totalCats.ToString();


            double totalBirds = (double.Parse(txtSkinBird.Text) + double.Parse(txtCDTBird.Text) + double.Parse(txtCPTBird.Text) + double.Parse(txtBloodBird.Text)
            + double.Parse(txtPregBird.Text) + double.Parse(txtEyeBird.Text) + double.Parse(txtEarBird.Text)
            + double.Parse(txtMammaryBird.Text) + double.Parse(txtVaxBird.Text) + double.Parse(txtCrastBird.Text) + double.Parse(txtLyBird.Text) + double.Parse(txtDewormBird.Text));

            txtTotalPatientsBirds.Text = totalBirds.ToString();

            double totalaPtients = (double.Parse(txtTotalPatientDogs.Text) + double.Parse(txtTotalPatientCats.Text) + double.Parse(txtTotalPatientsBirds.Text));
            txtTotalPatients.Text = totalaPtients.ToString();

            totalDogs = (double.Parse(val.Totalpdogs));
            //totalCats = (double.Parse(val.Totalpcats));    
            //totalBirds = (double.Parse(val.Totalpbird));
            //totalaPtients = (double.Parse(val.Totalpatientss));

            this.ChartDatePick.Text = DateTime.Now.ToString("MM/dd/yy");

            
            //patient.CountTotalSkinPatientDog();
            //txtSkinDog.Text = val.Totaldogs.ToString();


           // patient.CountTotalPatientCat(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtSkinDog.Text = val.Totalcat.ToString();

            //patient.CountTotalPatientBird(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtCPTDog.Text = val.Totalbird.ToString();

            //patient.TotalSalesToday(this.ChartDatePick.Text);
            //this.txtTotalDay.Text = val.TotalSalesToday;

            //patient.TotalSalesMonth(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtTotalMonth.Text = val.TotalSalesMonth;
            //
            //
            //patient.TotalSalesYear(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtTotalYear.Text = val.TotalSalesYear;


        //

            //patient.Totalpatient(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtBloodDog.Text = val.Totalpatient.ToString();


        //
            if (String.IsNullOrWhiteSpace(this.txtCDTDog.Text))
            {
                this.txtCDTDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtSkinDog.Text))
            {
                this.txtSkinDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtCPTDog.Text))
            {
                this.txtCPTDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtBloodDog.Text))
            {
                this.txtBloodDog.Text = "0";
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

            //foreach (var series in ChartDog.Series)
            {
              //  series.Points.Clear();
            }
            //foreach (var series in ChartCat.Series)
            {
              //  series.Points.Clear();
            }
            //foreach (var series in ChartBird.Series)
            {
              //  series.Points.Clear();
            }

            //foreach (var series in ChartSales.Series)
            {
               // series.Points.Clear();
            }

            //this.ChartDog.Series[0].Points.AddXY("Total Dog of Month", this.txtCDTDog.Text.ToString());
            //this.ChartCat.Series[0].Points.AddXY("Total Cat of Month", this.txtSkinDog.Text.ToString());
            //this.ChartBird.Series[0].Points.AddXY("Total Bird of Month", this.txtCPTDog.Text.ToString());

            this.ChartSales.Series[0].Points.AddXY("Today", this.txtTotalDay.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Month", this.txtTotalMonth.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Year", this.txtTotalYear.Text.ToString());

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
        }   

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //val.TotalSalesToday = this.txtTotalDay.Text;
            //val.TotalSalesMonth = this.txtTotalMonth.Text;
            //val.TotalSalesYear = this.txtTotalYear.Text;
            //val.Totalcat = int.Parse(this.txtSkinDog.Text);
            //val.Totaldogs = this.txtSkinDog.Text;
            //val.Totalbird = int.Parse(this.txtCPTDog.Text);
            val.ReportDate = this.ChartDatePick.Text;
            ReportTable rt = new ReportTable();
            rt.Show();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            this.ChartDatePick.Text = DateTime.Now.ToString("MM/dd/yy");

            //patient.CountTotalSkinPatientDog();
            //txtSkinDog.Text = val.Totaldogs.ToString();

           // patient.CountTotalCDTPatientDog();
            //txtCDTDog.Text = val.Totaldogs.ToString();

            //patient.CountTotalSkinPatientDog(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            // txtSkinDog.Text = val.Totaldogs.ToString();

            //patient.CountTotalSkinPatientDog(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtSkinDog.Text = val.Totaldogs.ToString();


            //patient.CountTotalPatientDog(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtSkinDog.Text = val.Totaldogs.ToString();

            //patient.CountTotalPatientCat(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtSkinDog.Text = val.Totalcat.ToString();

            //patient.CountTotalPatientBird(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtCPTDog.Text = val.Totalbird.ToString();

            patient.TotalSalesToday(this.ChartDatePick.Text);
            this.txtTotalDay.Text = val.TotalSalesToday;

            patient.TotalSalesMonth(this.ChartDatePick.Text.Substring(0, 2), this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalMonth.Text = val.TotalSalesMonth;

            patient.TotalSalesYear(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            this.txtTotalYear.Text = val.TotalSalesYear;

            //patient.Totalpatient(this.ChartDatePick.Text.Substring(this.ChartDatePick.Text.Length - 2));
            //this.txtBloodDog.Text = val.Totalpatient.ToString();

            if (String.IsNullOrWhiteSpace(this.txtCDTDog.Text))
            {
                this.txtCDTDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtSkinDog.Text))
            {
                this.txtSkinDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtCPTDog.Text))
            {
                this.txtCPTDog.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.txtBloodDog.Text))
            {
                this.txtBloodDog.Text = "0";
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

            //foreach (var series in ChartDog.Series)
            {
                ///series.Points.Clear();
            }
            //foreach (var series in ChartCat.Series)
            {
            //    series.Points.Clear();
            }
            //foreach (var series in ChartBird.Series)
            {
              //  series.Points.Clear();
            }

            //foreach (var series in ChartSales.Series)
            {
              //  series.Points.Clear();
            }

           //this.ChartDog.Series[0].Points.AddXY("Total Dog of Month", this.txtCDTDog.Text.ToString());
            //this.ChartCat.Series[0].Points.AddXY("Total Cat of Month", this.txtSkinDog.Text.ToString());
            //this.ChartBird.Series[0].Points.AddXY("Total Bird of Month", this.txtCPTDog.Text.ToString());

            this.ChartSales.Series[0].Points.AddXY("Today", this.txtTotalDay.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Month", this.txtTotalMonth.Text.ToString());
            this.ChartSales.Series[0].Points.AddXY("Year", this.txtTotalYear.Text.ToString());
        }
    }
    
}
