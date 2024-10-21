using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResillienceCalculatorNSWCDD
{
    public partial class frmSwitchboard : Form
    {
        public frmSwitchboard()
        {
            InitializeComponent();
        }

        // Declare ScoreManager as a field in MainMenuForm (or pass it in if it exists elsewhere)
        private ScoreManager _scoreManager = new ScoreManager();

        private void pbPhysical_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPhysicalRes frmPhysicalRes = new frmPhysicalRes(_scoreManager);
            frmPhysicalRes.Show();
        }

        private void pbHardware_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmHardwareRes frmHardwareRes = new frmHardwareRes(_scoreManager);
            frmHardwareRes.Show();
        }

        private void pbSoftware_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoftware frmSoftware = new frmSoftware(_scoreManager);
            frmSoftware.Show();
        }

        private void btnResilliencePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScoring frmScoring = new frmScoring(_scoreManager);
            frmScoring.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
