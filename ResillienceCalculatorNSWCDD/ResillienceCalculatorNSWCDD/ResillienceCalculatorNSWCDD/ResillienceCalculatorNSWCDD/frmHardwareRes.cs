//-----------------------------------------------------//
//                                                     //
//          USA CRAM SUBMISSION 10/20/2024             //
//      Chase Stevens, Ayrton Purdy, Chakriya Suon     //
//                Dr. Jeffery McDonald                 //
//                                                     //
//-----------------------------------------------------//

using Microsoft.Identity.Client;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.LinkLabel;

namespace ResillienceCalculatorNSWCDD
{
    public partial class frmHardwareRes : Form
    {
        private ScoreManager _scoreManager;

        public frmHardwareRes(ScoreManager scoreManager)
        {
            InitializeComponent();
            lstSelectedCVE.DrawMode = DrawMode.OwnerDrawFixed;
            lstSelectedCVE.DrawItem += LstSelectedCVE_DrawItem;
            _scoreManager = scoreManager;
        }

        public string calcSelectedCat;
        public string calcSelectedNode;
        public string calcFunctionList;
        public string calcSelectedSWMake;
        public string calcSelectedSWDesc;
        public string calcSelectedSWVer;
        public decimal calcEpssScore;


        public List<List<string>> nodeList = new List<List<string>>();

        //-----------------------------------------------------//
        //                                                     //
        //   Node List Pre-Read in on load event of the form   //
        //                                                     //
        //-----------------------------------------------------//

        private void ResillienceCalc_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader dataReader = new StreamReader("MASTERNodeList.csv"))
                {
                    string currentLine;
                    while ((currentLine = dataReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(currentLine))
                        {
                            // Split the line into fields and filter out empty or whitespace-only fields
                            string[] fields = currentLine.Split(',')
                                                         .Select(f => f.Trim()) // Trim leading/trailing spaces
                                                         .Where(f => !string.IsNullOrEmpty(f)) // Keep only non-empty fields
                                                         .ToArray();

                            // Create a list to hold the individual fields
                            List<string> row = new List<string>();

                            // Add the first 6 fields (if they exist)
                            for (int i = 0; i < Math.Min(6, fields.Length); i++)
                            {
                                row.Add(fields[i]); // Fields have already been trimmed, so just add them
                            }

                            // Combine the rest of the fields into a single string (if there are more than 5 fields)
                            if (fields.Length > 6)
                            {
                                string remainingFields = string.Join(",", fields.Skip(6));
                                row.Add(remainingFields); // Add the remaining fields as a single concatenated string
                            }

                            // Add the row to nodeList
                            nodeList.Add(row);

                            // Add the second field to the combobox (if it exists)
                            if (fields.Length > 1)
                            {
                                cboNode.Items.Add(fields[1]); // Add the second field to the combo box
                            }
                        }
                    }
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "Select an option"; //Will ignore on first pass
            if (cboNode.Text != condition)
            {
                cboAssociatedCVEs.Items.Clear();
                cboAssociatedCVEs.Text = "Please Recalculate Resillience";
                lstSelectedCVE.Items.Clear();
            }

            try
            {
                //read in node selected in combobox
                string selectedNode = cboNode.SelectedItem.ToString(); //grabs selected item from combobox
                //find the selected vendor in the list - loop through the list
                foreach (List<string> node in nodeList) //created a local array called node
                {
                    if (selectedNode == node[1])
                    {

                        calcSelectedCat = node[0];
                        calcSelectedNode = node[1];
                        calcFunctionList = node[2];
                        calcSelectedSWMake = node[3];
                        calcSelectedSWDesc = node[4];
                        calcSelectedSWVer = node[5];

                        lstOutput.Refresh();

                        return; //exits loop
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private decimal EPSS(string cve)
        {
            string formattedCve = cve.Split(';')[0].Trim();
            using (StreamReader epssReader = new StreamReader("epss_scores-2024-10-07.csv"))
            {
                string currentLine;
                while ((currentLine = epssReader.ReadLine()) != null)
                {
                    var fields = currentLine.Split(',');
                    if (fields[0] == formattedCve && decimal.TryParse(fields[1], out decimal epssScore))
                    {
                        return epssScore;
                    }
                }
            }
            return -1; // No match found
        }
        // Helper method to extract the numeric value from the NVD score string
        private string ExtractScoreValue(string nvdScoreStr)
        {
            // Example input: "(NVDScore: 6.7)"
            int startIndex = nvdScoreStr.IndexOf(':') + 1; // Find the colon and move one position ahead
            int endIndex = nvdScoreStr.IndexOf(')'); // Find the closing parenthesis
            if (startIndex > 0 && endIndex > startIndex)
            {
                // Extract the substring containing the numeric value and trim any extra spaces
                return nvdScoreStr.Substring(startIndex, endIndex - startIndex).Trim();
            }
            return "0"; // Default to "0" if parsing fails
        }

        //-----------------------------------------------------//
        //                                                     //
        //      ENTIRE NODE EPSS SYSTEM RESILLIENCY SCORE      //
        //                                                     //
        //-----------------------------------------------------//



        private void btnResillience_Click(object sender, EventArgs e)
        {
            Click_Reset();
            string fmtStr2 = "{0,-25} {1,10}";

            try
            {
                // Populate the output information
                lstOutput.Items.Clear();
                lstOutput.Items.Add(string.Format(fmtStr2, "Selected Node: ", calcSelectedNode));
                lstOutput.Items.Add(string.Format(fmtStr2, "Impacted Functions: ", calcFunctionList));
                lstOutput.Items.Add("");
                lstOutput.Items.Add(string.Format(fmtStr2, "Associated Category", calcSelectedCat));
                lstOutput.Items.Add("");
                lstOutput.Items.Add(string.Format(fmtStr2, "Software Make", calcSelectedSWMake));
                lstOutput.Items.Add(string.Format(fmtStr2, "Software Description", calcSelectedSWDesc));
                lstOutput.Items.Add(string.Format(fmtStr2, "Software Version", calcSelectedSWVer));

                //-----------------------------------------------------//
                //                                                     //
                //                  SOFTWARE VERSION                   //
                //   !! THIS DATA WOULD BE PRE-FED INTO THE SYSTEM !!  //
                //                                                     //
                //-----------------------------------------------------//


                List<string> outdatedSW = new List<string> { "RHEL 7.1", "RHEL 6.0", "RHEL 5.0", "IOS 15.2(1)E", "" };
                if (calcSelectedSWVer.Contains("RHEL 6.0") || calcSelectedSWVer.Contains("RHEL 5.0") || calcSelectedSWVer.Contains("RHEL 7.1"))
                {
                    warnRHEL_OutdatedSW.SetError(lstOutput, $"The latest version of Red Hat Enterprise Linux (RHEL) is 9.4");
                    //ADD POSSIBLE BONUS
                }
                if (calcSelectedSWVer.Contains("IOS 15.2(1)E"))
                {
                    warnCISCO_DiscontinuedSW.SetError(lstOutput, $"This CISCO product is at EOL and has been phased out.");
                    //ADD POSSIBLE BONUS
                }
                if (calcSelectedSWVer.Contains("Windows Server 2008 SP2"))
                {
                    warnWindowsServer_DiscontinuedSW.SetError(lstOutput, $"Windows 2008 SP2 is at EOL and has been phased out.");
                    //ADD POSSIBLE BONUS
                }

                // Add headers to the ListBox
                string header = string.Format("{0,-20} | {1,-10} | {2,-10}", "CVE", "EPSS Score", "NVD Score");
                string separator = new string('-', 50); // Separator line
                lstSelectedCVEs.Items.Add(header);
                lstSelectedCVEs.Items.Add(separator);
                // Initialize count and subtotal outside of the inner loop
                int count = 0;
                decimal subTotal = 0;

                foreach (List<string> node in nodeList)
                {
                    // Check if the node matches and ensure the row has enough fields
                    if (node.Count > 1 && calcSelectedNode == node[1])
                    {
                        for (int i = 6; i < node.Count; i++)
                        {
                            string[] cveEntries = node[i].Split(',');

                            // Debug: Check how many CVEs were found
                            Console.WriteLine($"Processing node index {i}: found {cveEntries.Length} CVEs.");

                            foreach (string cveEntry in cveEntries)
                            {
                                // Extract CVE code and NVD score from the entry
                                string[] parts = cveEntry.Split(';');
                                string cve = parts[0].Trim();
                                string nvdScore = parts.Length > 1 ? parts[1].Trim('(', 'N', 'V', 'D', 'S', 'c', 'o', 'r', 'e', ':', ' ', ')') : "N/A";

                                // Calculate the EPSS score for the CVE
                                decimal calcEpssScore = EPSS(cve);

                                // Format the string for display in the ListBox
                                string formattedEntry = $"{cve,-15} | {calcEpssScore,10} | {nvdScore,5}";
                                lstSelectedCVEs.Items.Add(formattedEntry);

                                // Update subtotal and count for average calculation
                                subTotal += calcEpssScore; // Add to subtotal
                                count++; // Increment count

                                // Add the CVE entry to the ComboBox for further selection
                                cboAssociatedCVEs.Items.Add(cveEntry.Trim());
                            }
                        }

                        // Check if any CVEs were processed to calculate the average score
                        if (count > 0)
                        {
                            decimal averageScore = subTotal / count; // Calculate the average EPSS score
                            //averageScore = averageScore * 100;
                            lstSelectedCVEs.Items.Add(new string('-', 55)); // Add a separator line
                            lstSelectedCVEs.Items.Add($"Average EPSS Score: {averageScore:F4}"); // Display the average score
                        }
                        else
                        {
                            lstSelectedCVEs.Items.Add(new string('-', 55)); // Add a separator line
                            lstSelectedCVEs.Items.Add("No CVEs processed for average calculation."); // Inform that no CVEs were processed
                        }

                        // Add the likelihood message
                        lstSelectedCVEs.Items.Add("0.00-1.00 likelihood an exploit will occur in the next 30 days.");
                    }
            }
                // Force the ListBox to refresh and redraw items with correct colors
                lstSelectedCVEs.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Function to determine severity level and score
        public int GetSeverityScore(string function)
        {
            int funcNumber = int.Parse(function.Substring(1)); // Extract number from function code
            if (funcNumber >= 1 && funcNumber <= 6) return 3;  // High Severity
            else if (funcNumber >= 7 && funcNumber <= 10) return 2; // Medium Severity
            else return 1; // Low Severity
        }

        public Dictionary<string, string> functionDescriptions = new Dictionary<string, string>
        {
            { "F1", "Engineering & Production" },
            { "F2", "Engineering & Production" },
            { "F3", "Engineering & Production" },
            { "F4", "Test Engineering" },
            { "F5", "IT & Cybersecurity" },
            { "F6", "IT & Cybersecurity" },
            { "F7", "Engineering & Production" },
            { "F8", "Test Engineering" },
            { "F9", "Test Engineering" },
            { "F10", "Company Management" },
            { "F11", "Engineering & Production" },
            { "F12", "Test Engineering" },
            { "F13", "Company Management" },
            { "F14", "Company Management" },
            { "F15", "Company Management" }
        };

        private void cboAssociatedCVEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstSelectedCVE.Items.Clear();
                string selectedCve = cboAssociatedCVEs.SelectedItem.ToString(); // Get the selected CVE from the ComboBox
                // Extract the CVE identifier and NVD score from the selectedCve string

                lstSelectedCVE.Items.Add("**Colors represent what is most critical to the company.");
                lstSelectedCVE.Items.Add("Impacted Business Functions:");

                decimal averageSeverity = 0;
                decimal cveResillience = 0;

                if (calcFunctionList != "??")
                {


                    // Split the input string and clean it
                    string[] functions = calcFunctionList.Split(';')
                                                         .Select(f => f.Trim('[', ' ', ']'))
                                                         .Where(f => !string.IsNullOrEmpty(f))
                                                         .ToArray();

                    if (functions.Length == 0)
                    {
                        lstSelectedCVE.Items.Add("No valid functions found to calculate severity.");
                        return;
                    }

                    Dictionary<string, int> functionCounts = new Dictionary<string, int>();
                    int subtotal = 0;

                    // Count occurrences and calculate subtotal
                    foreach (string function in functions)
                    {
                        if (functionCounts.ContainsKey(function))
                            functionCounts[function]++;
                        else
                            functionCounts[function] = 1;

                        // Accumulate severity score
                        subtotal += GetSeverityScore(function);
                    }

                    // Display each function with description and severity
                    var sortedFunctions = functionCounts.OrderBy(kvp => int.Parse(kvp.Key.Substring(1)));
                    foreach (var kvp in sortedFunctions)
                    {
                        string function = kvp.Key;
                        int count = kvp.Value;
                        string description = functionDescriptions.ContainsKey(function)
                            ? functionDescriptions[function]
                            : "Unknown function";

                        string severity = GetSeverityScore(function) switch
                        {
                            3 => "High",
                            2 => "Medium",
                            1 => "Low",
                            _ => "Unknown"
                        };

                        if (count > 1)
                        {
                            lstSelectedCVE.Items.Add($"{function} (x{count}) - {description} [{severity} Severity] function at risk");
                        }
                        else
                        {
                            lstSelectedCVE.Items.Add($"{function} - {description} [{severity} Severity] function at risk");
                        }
                    }
                    //lstSelectedCVE.Items.Add("");
                    lstSelectedCVE.Items.Add("-------------------------------------------------");
                    string[] cveParts = selectedCve.Split(';');
                    string cveId = cveParts[0].Trim(); // CVE-YEAR-NUMB
                    string nvdScore = cveParts.Length > 1 ? cveParts[1].Replace("(NVDScore: ", "").Replace(")", "").Trim() : "N/A";
                    // Prepare the formatted output
                    string formattedCveNvdDisplay = $"{cveId} | NVD Score of {nvdScore}:";
                    // Add the formatted output to the ListBox
                    lstSelectedCVE.Items.Add(formattedCveNvdDisplay); // Display the CVE and NVD

                    // Calculate the average severity score
                    averageSeverity = Convert.ToDecimal(subtotal) / functions.Length;

                    // Add an empty line for clarity
                    lstSelectedCVE.Items.Add("");

                    // Prepare the average severity text with the new format
                    string avgSeverityText = $"{averageSeverity:F2} / 3.0";

                    // Determine the severity label based on the average value
                    string severityLabel = averageSeverity switch
                    {
                        <= 1.0m => "Low Severity",
                        <= 2.0m => "Medium Severity",
                        _ => "High Severity"
                    };
                    lstSelectedCVE.Items.Add($"Average CVE Severity Score = {avgSeverityText} [{severityLabel}]");

                }
                else
                {
                    lstSelectedCVE.Items.Add("Unable to determine business function.");
                }

                //-----------------------------------------------------//
                //              INDIVIDUAL CVE EPSS SCORE              //
                //-----------------------------------------------------//
                calcEpssScore = EPSS(selectedCve); // Get the EPSS score for the selected CVE
                individualSelectedCVE = calcEpssScore;
                string formattedEpss = $"{calcEpssScore} / 1.0 ({calcEpssScore:P})";
                lstSelectedCVE.Items.Add($"Average CVE likelihood score (EPSS) = {formattedEpss}");

                //-----------------------------------------------------//
                //       CVE NORMALIZED AVERAGE RESILLIENCE SCORE      //
                //-----------------------------------------------------//
                // Input values
                decimal probability = calcEpssScore;
                decimal average = averageSeverity; //average function impact severity 1-3

                // Normalization parameters
                decimal A_min = 0.0m;
                decimal A_max = 3.0m;

                // Calculate normalized average
                decimal normalizedAverage = (average - A_min) / (A_max - A_min);

                // Combine normalized average with probability
                decimal combinedValue = probability + normalizedAverage;
                decimal CVEResillience = combinedValue;
                lstSelectedCVE.Items.Add("");
                lstSelectedCVE.Items.Add($"Full CVE Resillience: {CVEResillience:F3} / 3");
                lstSelectedCVE.Items.Add("**Please record this score.");

                lstSelectedCVE.Items.Add("");
                lstSelectedCVE.Items.Add("Associated APTs:");
                //code would be placed here to load in APTs and associated CVEs
                lstSelectedCVE.Items.Add("**Associated APTs would be put here");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public decimal individualSelectedCVE;
        private void LstSelectedCVE_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Ensure valid index

            // Get the item text
            string itemText = lstSelectedCVE.Items[e.Index].ToString();

            // Draw the background to ensure correct highlighting for selected items
            e.DrawBackground();

            // Check if the item is a business function or the average severity score
            if (itemText.Contains("function at risk"))
            {
                // Business function: color the entire line based on its severity
                Color itemColor = GetColorBySeverity(itemText);

                using (Brush brush = new SolidBrush(itemColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
                }
            }
            else
            {
                // Average severity score: color only the severity label
                string[] parts = SplitSeverityLabel(itemText);
                string mainText = parts[0]; // Main text (black)
                string severityLabel = parts[1]; // Severity label (colored)

                // Draw the main text in black
                using (Brush blackBrush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(mainText, e.Font, blackBrush, e.Bounds.X, e.Bounds.Y);
                }

                if (!string.IsNullOrEmpty(severityLabel))
                {
                    // Measure the width of the main text to position the severity label correctly
                    SizeF mainTextSize = e.Graphics.MeasureString(mainText, e.Font);
                    float severityX = e.Bounds.X + mainTextSize.Width;

                    // Get the color for the severity label
                    Color severityColor = GetColorBySeverity(severityLabel);

                    using (Brush severityBrush = new SolidBrush(severityColor))
                    {
                        e.Graphics.DrawString(severityLabel, e.Font, severityBrush, severityX, e.Bounds.Y);
                    }
                }
            }
            e.DrawFocusRectangle();
        }

        // Helper function to split the text into main text and severity label
        private string[] SplitSeverityLabel(string itemText)
        {
            int startIndex = itemText.IndexOf('[');

            if (startIndex >= 0)
            {
                string mainText = itemText.Substring(0, startIndex).Trim();
                string severityLabel = itemText.Substring(startIndex).Trim();
                return new[] { mainText, severityLabel };
            }
            else
            {
                return new[] { itemText, "" };
            }
        }

        // Helper function to determine the color based on the severity label or function
        private Color GetColorBySeverity(string itemText)
        {
            var severityColors = new Dictionary<string, Color>
            {
                { "High Severity", Color.Red },
                { "Medium Severity", Color.Orange },
                { "Low Severity", Color.Green }
            };

            foreach (var key in severityColors.Keys)
            {
                if (itemText.Contains(key))
                    return severityColors[key];
            }
            return Color.Black;
        }

        //-----------------------------------------------------//
        //                                                     //
        //    Send scores to Scoring Class to save on final    //
        //                      Scoring page                   //
        //-----------------------------------------------------//

        //-----------------------------------------------------//
        //                                                     //
        //     TOOL STRIP MENU / RESET METHODS / EXIT METHOD   //
        //                                                     //
        //-----------------------------------------------------//

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _scoreManager.hardwareScore = calcEpssScore; //Scoremanager class
            frmSwitchboard frmSwitchboard = new frmSwitchboard();
            frmSwitchboard.ShowDialog();
        }
        private void Click_Reset()
        {
            warnRHEL_OutdatedSW.Clear();
            warnCISCO_DiscontinuedSW.Clear();
            warnWindowsServer_DiscontinuedSW.Clear();
            cboAssociatedCVEs.Items.Clear();
            lstSelectedCVE.Items.Clear();
            lstSelectedCVEs.Items.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cboNode.Items.Clear();
            cboNode.Items.Add("Select an option");
            cboNode.SelectedIndex = 0;
            lstOutput.Items.Clear();
            cboAssociatedCVEs.Text = "";
            cboAssociatedCVEs.Items.Clear();
            //cboAssociatedCVEs.SelectedIndex = 0;
            lstSelectedCVE.Items.Clear();
            lstSelectedCVEs.Items.Clear();
            warnRHEL_OutdatedSW.Clear();
            warnCISCO_DiscontinuedSW.Clear();
            warnWindowsServer_DiscontinuedSW.Clear();

            try
            {
                using (StreamReader dataReader = new StreamReader("MASTERNodeList.csv"))
                {
                    string currentLine;
                    while ((currentLine = dataReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(currentLine))
                        {
                            // Split the line into fields and filter out empty or whitespace-only fields
                            string[] fields = currentLine.Split(',')
                                                         .Select(f => f.Trim()) // Trim leading/trailing spaces
                                                         .Where(f => !string.IsNullOrEmpty(f)) // Keep only non-empty fields
                                                         .ToArray();

                            // Create a list to hold the individual fields
                            List<string> row = new List<string>();

                            // Add the first 6 fields (if they exist)
                            for (int i = 0; i < Math.Min(6, fields.Length); i++)
                            {
                                row.Add(fields[i]); // Fields have already been trimmed, so just add them
                            }

                            // Combine the rest of the fields into a single string (if there are more than 5 fields)
                            if (fields.Length > 6)
                            {
                                string remainingFields = string.Join(",", fields.Skip(6));
                                row.Add(remainingFields); // Add the remaining fields as a single concatenated string
                            }

                            // Add the row to nodeList
                            nodeList.Add(row);

                            // Add the second field to the combobox (if it exists)
                            if (fields.Length > 1)
                            {
                                cboNode.Items.Add(fields[1]); // Add the second field to the combo box
                            }
                        }
                    }
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsmSetReset_Click(object sender, EventArgs e)
        {
            cboNode.Items.Insert(0, "Select an option");
            cboNode.SelectedIndex = 0;
            lstOutput.Items.Clear();
            cboAssociatedCVEs.Text = "";
            cboAssociatedCVEs.Items.Clear();
            lstSelectedCVE.Items.Clear();
            //lvSelectedCVEs.Items.Clear();
            warnRHEL_OutdatedSW.Clear();
            warnCISCO_DiscontinuedSW.Clear();
            warnWindowsServer_DiscontinuedSW.Clear();
        }
        private void tsmSetExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSwitchboard frmSwitchboard = new frmSwitchboard();
            frmSwitchboard.ShowDialog();
        }

        private void lstSelectedCVE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
