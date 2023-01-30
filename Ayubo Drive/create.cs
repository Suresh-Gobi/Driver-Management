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
    public partial class create : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        public create()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void create_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                    string sqlInsert;
                    sqlInsert = "Insert into register values ('" + nicTbx.Text + "', '" + nameTbx.Text + "','" + adrsTbx.Text + "','" + phoneTbx.Text + "','" + userTbx.Text + "', '" + passTbx.Text + "')";
                    SqlCommand cmd = new SqlCommand(sqlInsert, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Created");

                    Login log = new Login();
                    this.Hide();
                    log.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void nameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
