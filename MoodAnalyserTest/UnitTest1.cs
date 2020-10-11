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
        public void TestMethod1()
        {
            string inputMood = "I am in Any Mood";
            AnalyseMood mood = new AnalyseMood(inputMood);
            string moodOutput = mood.analysemood();

            Assert.AreEqual(moodOutput, "Happy");
        }
        [TestMethod]
        public void TestMethod1_2()
        {
            string inputMood = "I am in Sad Mood";
            AnalyseMood mood = new AnalyseMood(inputMood);
            string moodOutput = mood.analysemood();

            Assert.AreEqual(moodOutput, "Sad");
        }
    }
}
