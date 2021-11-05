using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using MoodAnalyser;


namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyseTestClass
    {
        [TestMethod]
        public void AnalyseMoodHappyOrSad()
        {
            // Test Case 1
            //Arrange
            string message = null;
            //string message= "I am in sad mood";
            //string message = "I am in happy mood";
            //string message = "I am in any mood";


            // string expected = "SAD";
            string expected = "happy";

            //Act
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass(message);
            string actual = moodAnalyserClass.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
