using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    // Severity score dictionary
    public static Dictionary<string, int> functionSeverityScore = new Dictionary<string, int>
    {
        { "F1", 3 }, { "F2", 3 }, { "F3", 3 }, { "F4", 3 }, { "F5", 3 }, { "F6", 3 },
        { "F7", 2 }, { "F8", 2 }, { "F9", 2 }, { "F10", 2 },
        { "F11", 1 }, { "F12", 1 }, { "F13", 1 }, { "F14", 1 }, { "F15", 1 }
    };

    static void Main(string[] args)
    {
        try
        {
            string nodeFilePath = "MASTERNodeList.csv";
            string epssFilePath = "epss_scores-2024-10-07.csv";
            string outputFilePath = @"C:\Users\ayrto\OneDrive\Desktop\CRAM Scores\CRAMResillienceUSAScoresPullv1.csv";

            var nodeCveData = ReadNodeCsv(nodeFilePath);
            var cveEpssMap = ReadEPSSScoresCsv(epssFilePath);

            List<decimal> nodeAverages = new List<decimal>();
            List<decimal> nodeSeverities = new List<decimal>();

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // Write the CSV headers
                writer.WriteLine("Node Name,Likelihood (Weighted EPSS),Severity (Weighted Function Severity)");

                // Process each node to calculate EPSS and severity averages
                foreach (var node in nodeCveData)
                {
                    decimal nodeEpssAvg = CalculateNodeAverage(node.Value.Item1, cveEpssMap);
                    decimal nodeSeverityAvg = CalculateSeverityAverage(node.Value.Item2);

                    // Write to console
                    Console.WriteLine($"Node: {node.Key}, Average EPSS: {nodeEpssAvg:F6}, Average Severity: {nodeSeverityAvg:F2}");

                    // Add to lists for final system-level averages
                    nodeAverages.Add(nodeEpssAvg);
                    nodeSeverities.Add(nodeSeverityAvg);

                    // Write node data to CSV
                    writer.WriteLine($"{node.Key},{nodeEpssAvg:F6},{nodeSeverityAvg:F2}");
                }

                // Calculate the final system-level averages
                decimal systemEpssAverage = nodeAverages.Sum() / nodeAverages.Count;
                decimal systemSeverityAverage = nodeSeverities.Sum() / nodeSeverities.Count;

                // Write system-level averages to console
                Console.WriteLine($"\nSystem Weighted Average EPSS Score: {systemEpssAverage:F6}");
                Console.WriteLine($"System Average Severity Score: {systemSeverityAverage:F2}");

                // Calculate and display the system resilience score using normalization
                decimal systemResilience = CalculateSystemResilience(systemEpssAverage, systemSeverityAverage);
                Console.WriteLine($"Total System Resilience: {systemResilience:F6}");

                // Write final system-level averages to the CSV
                writer.WriteLine($"\nSystem Averages,{systemEpssAverage:F6},{systemSeverityAverage:F2}");
                writer.WriteLine($"Total System Resilience,{systemResilience:F6}");
            }

            Console.WriteLine("\nResults successfully written to CRAMResillienceUSAScoresPullv1.csv.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Read the node CSV to extract CVE data and function severity per node
    static Dictionary<string, (List<string>, List<string>)> ReadNodeCsv(string filePath)
    {
        var data = new Dictionary<string, (List<string>, List<string>)>();

        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var fields = line.Split(',');
            string node = fields[1];

            // Extract CVEs
            var cves = fields.Skip(6)
                .Where(cve => !string.IsNullOrWhiteSpace(cve))
                .Select(cve => cve.Split(';')[0].Trim())
                .ToList();

            // Extract functions from the 3rd column, removing brackets and splitting by ';'
            var functions = fields[2]
                .Trim('[', ']')
                .Split(';')
                .Select(f => f.Trim())
                .ToList();

            data[node] = (cves, functions);
        }

        return data;
    }

    // Read the EPSS scores from the CSV
    static Dictionary<string, decimal> ReadEPSSScoresCsv(string filePath)
    {
        var map = new Dictionary<string, decimal>();

        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var fields = line.Split(',');
            if (fields.Length < 2) continue; // Skip invalid rows

            string cve = fields[0].Trim();
            if (decimal.TryParse(fields[1], out decimal epssScore))
            {
                map[cve] = epssScore;
            }
        }

        return map;
    }

    // Calculate the average EPSS score for a given node
    static decimal CalculateNodeAverage(List<string> cves, Dictionary<string, decimal> epssMap)
    {
        List<decimal> scores = new List<decimal>();

        foreach (var cve in cves)
        {
            decimal epssScore = EPSS(cve, epssMap);
            scores.Add(epssScore);
        }

        return scores.Count > 0 ? scores.Sum() / scores.Count : 0;
    }

    // Retrieve the EPSS score for a specific CVE with validation
    static decimal EPSS(string cve, Dictionary<string, decimal> epssMap)
    {
        if (epssMap.TryGetValue(cve, out decimal epssScore))
        {
            return epssScore;
        }

        Console.WriteLine($"Warning: EPSS score not found for CVE {cve}. Defaulting to 0.");
        return 0;
    }

    // Calculate the average severity score for a given node
    static decimal CalculateSeverityAverage(List<string> functions)
    {
        List<int> severities = new List<int>();

        foreach (var function in functions)
        {
            if (functionSeverityScore.TryGetValue(function, out int severity))
            {
                severities.Add(severity);
            }
            else
            {
                Console.WriteLine($"Warning: Unknown function {function}. Defaulting to severity 0.");
                severities.Add(0);
            }
        }

        return severities.Count > 0 ? (decimal)severities.Sum() / severities.Count : 0;
    }

    // Calculate system resilience using normalization of EPSS and severity
    static decimal CalculateSystemResilience(decimal epssAverage, decimal severityAverage)
    {
        // Normalization parameters
        decimal A_min = 0.0m;
        decimal A_max = 3.0m;

        // Normalize severity (shift range from 1-3 to 0-3)
        decimal normalizedSeverity = (severityAverage - 1) / 2 * (A_max - A_min);

        // Combine normalized severity with EPSS average
        decimal combinedValue = epssAverage + normalizedSeverity;

        // Output normalized values (optional for debugging)
        Console.WriteLine($"Normalized Severity: {normalizedSeverity:F4}");
        Console.WriteLine($"Combined Value: {combinedValue:F6}");

        return combinedValue;
    }
}
