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
    public partial class Vehicle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        public Vehicle()
        {
            InitializeComponent();
        }
        private void clear()
        {

            VtypeTbx.Clear();
            DDrateTbx.Clear();
            RegTbx.Clear();
            DrateTbx.Clear();
            WrateTbx.Clear();
            MrateTbx.Clear();
            VbrandCmb.Text="";
            FtypeCmb.Text="";
            ACchk.Checked = false;
            NonACchk.Checked = false;
            VtypeTbx.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void serachBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "select * from vehicle where RegNo = '" + RegTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    VtypeTbx.Text = dr["VType"].ToString();
                    VbrandCmb.Text = dr["Make"].ToString();
                    FtypeCmb.Text = dr["Fuel_Type"].ToString();
                    DrateTbx.Text = dr["Daily_Rate"].ToString();
                    WrateTbx.Text = dr["Weekly_Rate"].ToString();
                    MrateTbx.Text = dr["Monthly_Rate"].ToString();
                    DDrateTbx.Text = dr["Daily_Dr_Rate"].ToString();
                    
                    if (dr["AC"].Equals("AC        "))
                        ACchk.Checked = true;
                    else
                        NonACchk.Checked = true;


                }
                else
                {
                    MessageBox.Show("ERROR");


                }
                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String airCondition;
                if (ACchk.Checked == true)
                    airCondition = "AC";
                else
                    airCondition = "Non-AC";

                string sqlInsert;
                sqlInsert = "Insert into vehicle (RegNo, VType, Make, Daily_Rate, Weekly_Rate, Monthly_Rate, Daily_Dr_Rate, Fuel_Type, AC) values ('" + RegTbx.Text + "', '" + VtypeTbx.Text + "', '" + VbrandCmb.Text + "','" + DrateTbx.Text + "','" + WrateTbx.Text + "','" + MrateTbx.Text + "','" + DDrateTbx.Text + "','" + FtypeCmb.Text + "','" + airCondition + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String airCondition;
                if (ACchk.Checked == true)
                    airCondition = "AC";
                else
                    airCondition = "Non-AC";
                string sqlUpdate;
                sqlUpdate = "update vehicle set VType='" + VtypeTbx.Text + "', Make='" + VbrandCmb.Text + "', Daily_Rate='" + DrateTbx.Text + "', Weekly_Rate='" + WrateTbx.Text + "', Monthly_Rate='" + MrateTbx.Text + "', Daily_Dr_Rate='" + DDrateTbx.Text + "', Fuel_Type='" + FtypeCmb.Text + "', AC='" + airCondition + "' where RegNo = '" + RegTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlDelete;
                sqlDelete = "delete from vehicle where RegNo = '" + RegTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
