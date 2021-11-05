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
            string message = "I am in sad mood";
           // string message = "I am in happy mood";

            string expected = "SAD";

            //Act
            MoodAnalyserClass moodAnalyserClass  = new MoodAnalyserClass(message );
            string actual = moodAnalyserClass.AnalyzeMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
