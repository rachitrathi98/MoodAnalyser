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
        public string Analysemood()
        {
            try
            {
                if (this.mood.Contains("Sad"))
                {
                    return "Sad Mood";
                }
                if (this.mood.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.ENTERED_EMPTY, "String shouldn't be empty");
                }

                return "Happy Mood";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.ENTERED_NULL, "string shouldn't be null");
            }
        }
    }
}

