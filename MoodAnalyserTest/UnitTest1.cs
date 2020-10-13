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
        public void GivenMoodAnalyserReflection_Return_MoodAnalyserParameterizedObject()
        {
            var obj = new AnalyseMood("happy");
            object result = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyser.AnalyseMood", "AnalyseMood", "happy");
            obj.Equals(result);
        }
        [TestMethod]
        public void GivenHappyMood_ShouldReturn_HappyMessage()
        {
            var expected = "happy";
            string mood = MoodAnalyserFactory.InvokeAnalyserMethod("happy", "Analysemood");
            expected.Equals(mood);
        }

        [TestMethod]
        public void GivenHappyMoodImproperMethod_ShouldReturn_HappyMessage()
        {
            string expected = "method not found";
            string actual = "";
            try
            {
                string mood = MoodAnalyserFactory.InvokeAnalyserMethod("happy", "Analysemoods");
            }
            catch(MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }
            expected.Equals(actual);
        }

    }
}