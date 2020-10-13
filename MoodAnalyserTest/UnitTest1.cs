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
            var obj = new AnalyseMood();
            try
            {
                object result = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.AnalyseMood", "AnalyseMood");

            }
            catch (Exception)
            {

            }
        }

    }
}