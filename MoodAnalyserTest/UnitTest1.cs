using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test the string 
        /// </summary>
        [TestMethod]
        public void ReturnSadMoodForSad()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            AnalyseMood moodAnalyzer = new AnalyseMood(message);

            //Act
            string mood = moodAnalyzer.Analysemood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow(null)]
        public void ReturnHappyMoodForHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            AnalyseMood moodAnalyzer = new AnalyseMood(message);
            //Act
            string mood = moodAnalyzer.Analysemood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}



