using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResillienceCalculatorNSWCDD
{
    public class ScoreManager
    {
        // Properties to store individual scores from each form
        public decimal physicalScore { get; set; } // Range: 0-1
        public decimal hardwareScore { get; set; } // Range: 0-3
        public decimal softwareScore { get; set; } // Range: 0-1

        // Constructor
        public ScoreManager()
        {
            physicalScore = 0;
            hardwareScore = 0;
            softwareScore = 0;
        }

        public decimal GetPhysicalScore()
        {
            return physicalScore;
        }

        public decimal GetHardwareScore()
        {
            return hardwareScore;
        }

        public decimal GetSoftwareScore()
        {
            return softwareScore;
        }

        // Method to calculate the total score (out of 5)
        public decimal GetTotalScore()
        {
            return physicalScore + hardwareScore + softwareScore;
        }
    }
}
