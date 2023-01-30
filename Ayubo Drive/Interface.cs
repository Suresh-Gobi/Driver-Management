using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Interface_Load(object sender, EventArgs e)
        {
            timer1.Start(); // start 
        }

        int startpoint = 30; // starting point will be 30 

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            startpoint += 1; // increase by one
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 100;
                timer1.Stop();

                Login log = new Login();
                this.Hide();
                log.Show();
        }
        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
