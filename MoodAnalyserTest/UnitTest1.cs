using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNullMessage()
        {
            string actual;
            try
            {
                //Arrange
                AnalyseMood mood = new AnalyseMood(null);
                //Act
                actual = mood.Analysemood();
            }
            catch (MoodAnalyserCustomException e)
            {
                actual = e.Message;
            }
            //Assert
            Assert.AreNotEqual("Happy Mood", actual);
        }
        [TestMethod]
        public void TestHappyMessage()
        {
            AnalyseMood mood = new AnalyseMood("I am in Happy Mood right now");
            string actual = mood.Analysemood();
            Assert.AreEqual("Happy Mood", actual);
        }

        [TestMethod]
        public void TestSadMessage()
        {
            AnalyseMood mood = new AnalyseMood("I am in Sad Mood right now");
            string actual = mood.Analysemood();
            Assert.AreEqual("Sad Mood", actual);
        }

    }
}