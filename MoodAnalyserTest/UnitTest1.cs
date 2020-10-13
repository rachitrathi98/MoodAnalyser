using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyserReflection_Return_MoodAnalyserObject()
        {
            var obj = new AnalyseMood();
            object result = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.AnalyseMood", "AnalyseMood");
            obj.Equals(result);
        }
        [TestMethod]
        public void GivenImproperClassName_Return_MoodAnalysisException()
        {
            string expected= "class not found";
            string actual = "";
            try
            {
                object result = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.AnalyseMoods", "AnalyseMoods");

            }
            catch (MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenImproperConstructor_Return_MoodAnalysisException()
        {
            string expected = "constructor not found";
            string actual = "";
            try
            {
                object result = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.AnalyseMood", "AnalyseMoods");

            }
            catch (MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }
            Assert.AreEqual(expected, actual);
        }

    }
}