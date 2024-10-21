using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResillienceCalculatorNSWCDD
{
    public partial class frmPhysicalRes : Form
    {
        private ScoreManager _scoreManager;

        public frmPhysicalRes(ScoreManager scoreManager)
        {
            InitializeComponent();
            _scoreManager = scoreManager;
        }

        public decimal totalPhysicalScore;

        private void btnCalculate_Click_1(object sender, EventArgs e)
            {
            // Parse input scores
            decimal score1 = Convert.ToDecimal(txtScore1.Text);
            decimal score2 = Convert.ToDecimal(txtScore2.Text);
            decimal score3 = Convert.ToDecimal(txtScore3.Text);
            decimal score4 = Convert.ToDecimal(txtScore4.Text);
            decimal score5 = Convert.ToDecimal(txtScore5.Text);

            // Add scores to the list box
            /*lstPhysicalOutput.Items.Add(score1);
            lstPhysicalOutput.Items.Add(score2);
            lstPhysicalOutput.Items.Add(score3);
            lstPhysicalOutput.Items.Add(score4);
            lstPhysicalOutput.Items.Add(score5);*/

            // Calculate the subtotal
            decimal subTotal = score1 + score2 + score3 + score4 + score5;

            // Assume each score is out of 100, so the maximum total is 5 * 100 = 500
            decimal maxPossibleTotal = 5 * 100;

            // Normalize the total to a value between 0 and 1
            decimal normalizedTotal = subTotal / maxPossibleTotal;

            // Display the normalized score in the list box
            lstPhysicalOutput.Items.Add($"Total Score: {normalizedTotal:P2}"); // Display as percentage
            lstPhysicalOutput.Items.Add("");
            lstPhysicalOutput.Items.Add("Please record this score");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtScore4.Clear();
            txtScore5.Clear();
            lstPhysicalOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _scoreManager.physicalScore = totalPhysicalScore;
            frmSwitchboard frmSwitchboard = new frmSwitchboard();
            frmSwitchboard.ShowDialog();
        }
    }
}
