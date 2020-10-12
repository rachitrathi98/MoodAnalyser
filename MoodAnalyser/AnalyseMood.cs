using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class AnalyseMood
    {
        private string mood = "";
        /// <summary>
        ///Setting parameterized constructor to take message
        /// </summary>
        /// <param name="inputMessage">The input message.</param>
        public AnalyseMood(string inputMessage)
        {
            this.mood = inputMessage;
        }
        /// <summary>
        /// Check if sad or happy
        /// </summary>
        /// <returns></returns>
        public string analysemood()
        {
            try {
                if (this.mood.Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}

