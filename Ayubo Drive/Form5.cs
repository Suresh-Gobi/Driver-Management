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
    public partial class LongTour : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        DateTime rented, returned;
        TimeSpan dateiff;
        Double totDays;
        
        public LongTour()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "select * from Package where pId = '" + packageIDtbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                pnameTbx.Text = dr["pName"].ToString();
                pRateTbx.Text = dr["pRate"].ToString();
                maxKmTbx.Text = dr["maxKm"].ToString();
                DNightRTbx.Text = dr["drPerNightRate"].ToString();
                ExtrakmTBX.Text = dr["extraPerRate"].ToString();
                VNiRateTbx.Text = dr["vehiclePerNightRate"].ToString();

                con.Close();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CalDaysBtn_Click(object sender, EventArgs e)
        {
            try
            {
                rented = DateTime.Parse(rented1.Text);
                returned = DateTime.Parse(returned2.Text);
                dateiff = returned - rented;
                totDays = dateiff.TotalDays;
                totalDaysTbx.Text = totDays.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CalKmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double startKm, endKm, nKm, maxKm, exKm, exKmRate, exKmChg, allocateKm, nDays;

                startKm = double.Parse(kmReadingTbx.Text);
                endKm = double.Parse(EndKmReadingTbx.Text);
                
                if (endKm > startKm)
                {
                    MessageBox.Show("Invaild End Km");
                }

                nKm = endKm - startKm;
                NoKmTbx.Text = nKm.ToString();

                maxKm = double.Parse(maxKmTbx.Text);
                nDays = double.Parse(totalDaysTbx.Text);
                allocateKm = maxKm * nDays;

                if (nKm > allocateKm)
                {
                    exKm = nKm - allocateKm;

                }

                else
                {
                    exKm = 0;
                }

                exKmTbx.Text = exKm.ToString();

                exKmRate = double.Parse(ExtrakmTBX.Text);
                exKmChg = exKm * exKmRate;
                exKmChTbx.Text = exKmChg.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TotCalKmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Total Amout Calculation

                int noDays;
                double BaseChg, DrNiChg, VehicleNiChg, OverNightChg, PRate, kmCost;
                double totalAmt;

                PRate = double.Parse(pRateTbx.Text);
                noDays = int.Parse(totalDaysTbx.Text);
                BaseChg = PRate * noDays;               // Package Rate
                hireTbx.Text = Convert.ToString(BaseChg);

                DrNiChg = double.Parse(DNightRTbx.Text);
                VehicleNiChg = double.Parse(VNiRateTbx.Text);
                OverNightChg = (DrNiChg + VehicleNiChg) * (noDays - 1); // Over Night charge Calculation
                OverNightTbx.Text = Convert.ToString(OverNightChg);

                kmCost = double.Parse(exKmChTbx.Text);
                ExtrakmchgTbx.Text = Convert.ToString(kmCost);

                totalAmt = BaseChg + OverNightChg + kmCost; // Total Amount
                TotalCostTbx.Text = totalAmt.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
