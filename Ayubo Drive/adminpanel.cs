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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle newMDI = new Vehicle();
            newMDI.MdiParent = this;
            newMDI.Show();
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           package newMDI = new package();
            newMDI.MdiParent = this;
            newMDI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login exit = new Login();
            this.Hide();
            exit.Show();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
