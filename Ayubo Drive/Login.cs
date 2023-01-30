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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SURESHGOBI;Initial Catalog=Ayubo Drive;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void userRdB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {
            create log = new create();
            this.Hide();
            log.Show();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string admin = userTbx.Text;
                string pass = passTbx.Text;

                SqlDataAdapter sqladpter = new SqlDataAdapter("SELECT COUNT(*) FROM register WHERE username='" + userTbx.Text + "' AND password='" + passTbx.Text + "'", con);

                DataTable dt = new DataTable();
                sqladpter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1" && userRdB.Checked == true)
                {
                    userpanel log = new userpanel();
                    this.Hide();
                    log.Show();
                }

                else if (admin == "admin123" && pass == "password123" && adminRdB.Checked == true)
                {

                    adminpanel log = new adminpanel();
                    this.Hide();
                    log.Show();

                }

                else
                    MessageBox.Show("Invalid username or password");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
