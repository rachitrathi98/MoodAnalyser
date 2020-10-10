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
            if (this.mood.Equals("Happy"))
            {
                this.mood = "Happy";
            }
            else if (this.mood.Equals("Sad"))
            {
                this.mood = "Sad";
            }
            else
            {
                this.mood = "Invalid";
            }
            return this.mood;
        }
    }
}
