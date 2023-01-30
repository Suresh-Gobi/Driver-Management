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
    public partial class rent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        DateTime rented, returned;
        TimeSpan dateiff;
        Double totDays;
        int totaldays, months, weeks, days;
        int remainder;

        public rent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

rented = DateTime.Parse(rented1.Text);
returned = DateTime.Parse(returned2.Text);
dateiff = returned - rented;
totDays = dateiff.TotalDays;
totDays = dateiff.TotalDays;
textBox1.Text = totDays.ToString();



totaldays = int.Parse(textBox1.Text);

months = totaldays / 30;

weeks = (totaldays % 30) / 7;
textBox2.Text = months.ToString();

remainder = totaldays % 30;
weeks = remainder / 7;
textBox3.Text = weeks.ToString();


days = remainder % 7;
textBox4.Text = days.ToString(); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double mRate, wRate, dRate, drRate;
double amt;
mRate = double.Parse(textBox7.Text);
wRate = double.Parse(textBox8.Text);
dRate = double.Parse(textBox9.Text);
drRate = double.Parse(textBox11.Text);
amt = (months * mRate + weeks * wRate + days * dRate);
            if (checkBox1.Checked == true)
                amt = amt + (drRate * totDays);
textBox10.Text = amt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "select * from vehicle where RegNo = '" + textBox5.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox6.Text = dr["VType"].ToString();
                    comboBox1.Text = dr["Make"].ToString();
                    textBox9.Text = dr["Daily_Rate"].ToString();
                    textBox8.Text = dr["Weekly_Rate"].ToString();
                    textBox7.Text = dr["Monthly_Rate"].ToString();
                    textBox11.Text = dr["Daily_Dr_Rate"].ToString();
                    
                    con.Close();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rented1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void returned2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
