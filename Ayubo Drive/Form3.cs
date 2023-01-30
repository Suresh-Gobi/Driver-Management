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
    public partial class package : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        public package()
        {
            InitializeComponent();
        }

        private void clear()
        {

            packageTbx.Clear();
            packagenameTbx.Clear();
            vehicletypeTbx.Clear();
            packageRtTbx.Clear();
            maxkmTbx.Clear();
            extrakmTbx.Clear();
            maxhrTbx.Clear();
            extraHrTbx.Clear();
            DrNiRaTbx.Clear();
            VeNiRaTbx.Clear();
            packageTbx.Focus();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSearch;
                sqlSearch = "select * from Package where pId = '" + packageTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                packagenameTbx.Text = dr["pName"].ToString();
                vehicletypeTbx.Text = dr["vType"].ToString();
                packageRtTbx.Text = dr["pRate"].ToString();
                maxkmTbx.Text = dr["maxKm"].ToString();
                extrakmTbx.Text = dr["extraPerKmRate"].ToString();
                maxhrTbx.Text = dr["maxHrs"].ToString();
                extraHrTbx.Text = dr["extraPerRate"].ToString();
                DrNiRaTbx.Text = dr["drPerNightRate"].ToString();
                VeNiRaTbx.Text = dr["vehiclePerNightRate"].ToString();

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

                string sqlInsert;
                sqlInsert = "Insert into Package (pId,pName,vType,pRate,maxKm,extraPerKmRate,maxHrs,extraPerRate,drPerNightRate,vehiclePerNightRate) values ('" + packageTbx.Text + "', '" + packagenameTbx.Text + "', '" + vehicletypeTbx.Text + "','" + packageRtTbx.Text + "','" + maxkmTbx.Text + "','" + extrakmTbx.Text + "','" + maxhrTbx.Text + "','" + extraHrTbx.Text + "','" + DrNiRaTbx.Text + "','" + VeNiRaTbx.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

                clear();

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
                string sqlUpdate;
                sqlUpdate = "update Package set pName='" + packagenameTbx.Text + "', vType='" + vehicletypeTbx.Text + "', pRate='" + packageRtTbx.Text + "',maxKm='" + maxkmTbx.Text + "', extraPerKmRate='" + extrakmTbx.Text + "', maxHrs='" + maxhrTbx.Text + "', extraPerRate='" + extraHrTbx.Text + "', drPerNightRate='" + DrNiRaTbx.Text + "', vehiclePerNightRate = '" + VeNiRaTbx.Text + "' where pId = '" + packageTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");
                // clear();
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
                sqlDelete = "delete from Package where pId = '" + packageTbx.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");

                //clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
