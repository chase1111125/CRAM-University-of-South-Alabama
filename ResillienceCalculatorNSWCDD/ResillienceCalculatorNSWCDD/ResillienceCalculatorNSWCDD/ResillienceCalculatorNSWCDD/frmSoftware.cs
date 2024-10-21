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
    public partial class frmSoftware : Form
    {
        private ScoreManager _scoreManager;

        public frmSoftware(ScoreManager scoreManager)
        {
            InitializeComponent();
            _scoreManager = scoreManager;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSwitchboard frmSwitchboard = new frmSwitchboard();
            frmSwitchboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the output list to start fresh
            lstOutput.Items.Clear();
            lstOutput.Items.Add("Test");
            lstOutput.Items.Add($"{txtAmtOfFiles.Text} # of files");
            lstOutput.Items.Add($"Entropy Average: {txtAverageEntropy.Text}");

            try
            {
                // Parse the input values from text boxes
                double totalEntropyScore = Convert.ToDouble(txtAverageEntropy.Text.Trim());
                double totalAmtOfFiles = Convert.ToDouble(txtAmtOfFiles.Text.Trim());

                // Avoid division by zero
                if (totalAmtOfFiles == 0)
                {
                    MessageBox.Show("Amount of Files cannot be zero. Please enter a valid number.");
                    return;
                }

                // Calculate the raw software resilience score
                double softwareResilience = totalEntropyScore / totalAmtOfFiles;

                // Normalize (clip) the software resilience value to stay within 0-1
                softwareResilience = Math.Max(0, Math.Min(1, softwareResilience));

                // Display the normalized result in the list box
                lstOutput.Items.Add("");
                lstOutput.Items.Add($"Software Resilience: {softwareResilience:F2}");  // Format to 2 decimal places
                lstOutput.Items.Add("**TPlease record this score.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAverageEntropy.Text = "";
            txtAmtOfFiles.Text = "";
            lstOutput.Items.Clear();
        }
    }
}
