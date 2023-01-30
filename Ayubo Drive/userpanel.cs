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
    public partial class userpanel : Form
    {
        public userpanel()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rent newMDI = new rent();
            newMDI.MdiParent = this;
            newMDI.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void dayTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DayTour newMDI = new DayTour();
            newMDI.MdiParent = this;
            newMDI.Show();
        }

        private void longTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LongTour newMDI = new LongTour();
            newMDI.MdiParent = this;
            newMDI.Show();
        }

        private void userpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
