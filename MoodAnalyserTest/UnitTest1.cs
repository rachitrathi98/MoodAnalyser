using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {   /// <summary>
        /// Setup Method to Initialise Object and this method will be invoked in each test method
        /// </summary>

        AnalyseMood mood = null;
        [TestInitialize]
        public void SetUp ()
        {
             mood = new AnalyseMood("Sad");
        }
        /// <summary>
        /// Test the string 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string moodOutput = mood.analysemood();
            Assert.AreEqual("Sad", moodOutput);
        }
    }
}
