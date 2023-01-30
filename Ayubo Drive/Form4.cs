using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ayubo_Drive
{
    public partial class DayTour : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        public DayTour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
                    }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "select * from Package where pId = '" + packageIdTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                packageNameTbx.Text = dr["pName"].ToString();
                maxKmTbx.Text = dr["maxKm"].ToString();
                ExtraKmTbx.Text = dr["extraPerKmRate"].ToString();
                maxHrTbx.Text = dr["maxHrs"].ToString();
                ExtraHrTbx.Text = dr["extraPerRate"].ToString();
                packageRTbx.Text = dr["PRate"].ToString();

                con.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            DateTime startTime, endTime;
            TimeSpan ts;
            int nHrs, maxHrs, exHrs;
            double exHrRate, exHrChg;

            startTime = DateTime.Parse(StartTime.Text);
            endTime = DateTime.Parse(EndTime.Text);
            ts = endTime - startTime;
            nHrs = ts.Hours;
            noHrTbx.Text = nHrs.ToString();

            maxHrs = int.Parse(maxHrTbx.Text);
            if (nHrs > maxHrs)
            {
                exHrs = nHrs - maxHrs;

            }

            else
            {
                exHrs = 0;
            }

            extrahourTbx.Text = exHrs.ToString();

            exHrRate = double.Parse(ExtraHrTbx.Text);
            exHrChg = exHrs * exHrRate;
            ExtraHrChTbx.Text = exHrChg.ToString();
        
        }

        private void calculateKmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double startKm, endKm, nKm, maxKm, exKm, exKmRate, exKmChg;

                startKm = double.Parse(StartKmTbx.Text);
                endKm = double.Parse(EndKmTbx.Text);
                nKm = endKm - startKm;
                NoKmTbx.Text = nKm.ToString();

                maxKm = double.Parse(maxKmTbx.Text);
                if (nKm > maxKm)
                {
                    exKm = nKm - maxKm;

                }

                else
                {
                    exKm = 0;
                }

                ExtraKTbx.Text = exKm.ToString();

                exKmRate = double.Parse(ExtraKmTbx.Text);
                exKmChg = exKm * exKmRate;
                ExtraKmchrTbx.Text = exKmChg.ToString();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void calculateDatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Total Amount for the Day Tour 
                double pRate, exHrRate, exKmRate;
                double amt;
                pRate = double.Parse(packageRTbx.Text);
                exHrRate = double.Parse(ExtraHrChTbx.Text);
                exKmRate = double.Parse(ExtraKmchrTbx.Text);
                amt = (pRate + exHrRate + exKmRate); // Day tour calculation
                totalCostTbx.Text = amt.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
