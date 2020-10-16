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
        /// <summary>
        /// UC 6.1: Given happy message using reflection when proper should return happy mood
        /// </summary>
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
        /// <summary>
        /// UC 6.2: should throw return happy message should throw MoodAnalysisException
        /// </summary>
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
        /// <summary>
        /// UC 7.1: Given the happy message return happy.
        /// </summary>
        [TestMethod]
        public void GivenHappy_ReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = MoodAnalyserFactory.SetField("HAPPY", "message");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC 7.2:When Set field is improper should throw exception.
        /// </summary>
        [TestMethod]
        public void SetFieldWhenImproper_ShouldThrowException()
        {
            try
            {
                object result = MoodAnalyserFactory.SetField("HAPPY", "mes");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Field is not found", exception.Message);
            }
        }
        /// <summary>
        /// UC 7.3: Sets the null message should throwxception.
        /// </summary>
        [TestMethod]
        public void SetNullMessage_ShouldThrowxception()
        {
            try
            {
                object result = MoodAnalyserFactory.SetField(null, "message");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Message should not be null", exception.Message);
            }
        }
    }
}