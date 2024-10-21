using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ResillienceCalculatorNSWCDD
{
    public partial class frmScoring : Form
    {
        private const string ScoresFilePath = "scores.json";  // Path to store scores

        private ScoreManager _scoreManager;

        public frmScoring(ScoreManager scoreManager)
        {
            InitializeComponent();
            _scoreManager = scoreManager;
        }

        private void btnCalcFinalResillience_Click(object sender, EventArgs e)
        {
            // Parse the input scores
            decimal physicalScore = Convert.ToDecimal(txtPhysical.Text);
            decimal hardwareScore = Convert.ToDecimal(txtHardware.Text);
            decimal softwareScore = Convert.ToDecimal(txtSoftware.Text);

            // Calculate the total resilience score
            decimal totalResilienceScore = physicalScore + hardwareScore + softwareScore;
            txtFinalScore.Text = totalResilienceScore.ToString("F4");

            // Set the risk color based on the score
            SetRiskColor(totalResilienceScore);

            // Create a new score entry with a timestamp-based ID
            var scoreEntry = new ScoreEntry
            {
                Id = GenerateTimestampId(),
                Physical = physicalScore,
                Hardware = hardwareScore,
                Software = softwareScore,
                TotalScore = totalResilienceScore
            };

            // Save the score entry to the JSON file
            SaveScoreToFile(scoreEntry);
        }

        private void SetRiskColor(decimal score)
        {
            if (score <= 2.25m)
            {
                lbRisk.BackColor = Color.Green;
                lbRisk.Text = "Low Risk";
            }
            else if (score > 2.25m && score <= 3.75m)
            {
                lbRisk.BackColor = Color.Yellow;
                lbRisk.Text = "Medium Risk";
            }
            else if (score > 3.75m)
            {
                lbRisk.BackColor = Color.Red;
                lbRisk.Text = "High Risk";
            }
        }

        private string GenerateTimestampId()
        {
            // Generate an ID based on the current date and time: MMDDYYHHmm
            return DateTime.Now.ToString("MMddyyHHmm");
        }

        private void SaveScoreToFile(ScoreEntry newEntry)
        {
            try
            {
                List<ScoreEntry> allScores;

                // Read existing scores or create a new list if the file doesn't exist
                if (File.Exists(ScoresFilePath))
                {
                    string json = File.ReadAllText(ScoresFilePath);
                    allScores = JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
                }
                else
                {
                    allScores = new List<ScoreEntry>();
                }

                // Add the new score entry to the list
                allScores.Add(newEntry);

                // Serialize the updated list to JSON with indentation for readability
                string updatedJson = JsonSerializer.Serialize(allScores, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON to the file
                File.WriteAllText(ScoresFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save the score: {ex.Message}");
            }
        }

        // Define a class to represent each score entry
        private class ScoreEntry
        {
            public string Id { get; set; }  // Timestamp-based ID
            public decimal Physical { get; set; }  // Physical score out of 1
            public decimal Hardware { get; set; }  // Hardware score out of 3
            public decimal Software { get; set; }  // Software score out of 1
            public decimal TotalScore { get; set; }  // Total resilience score
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPhysical.Text = "";
            txtHardware.Text = "";
            txtSoftware.Text = "";
            lbRisk.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSwitchboard frmSwitchBoard = new frmSwitchboard();
            frmSwitchBoard.ShowDialog();
        }
    }
}
