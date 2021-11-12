using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using MoodAnalyser;
using System;


namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyseTestClass
    {
        [TestMethod]
        [TestCategory ("CheckMood")]
        public void AnalyseMoodHappyOrSad()
        {
            // Test Case 1
            //Arrange
            string message= "I am in sad mood";
            //string message = "I am in happy mood";
            //string message = "I am in any mood";


            string expected = "SAD";
            //string expected = "happy";

            //Act
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass(message);
            string actual = moodAnalyserClass.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod ]
        [TestCategory ("CustomException")]
        public void getCustomException()
        {
            //Arrange
            string message = null;
            string expected = "Message Should Not Be Null";

            //Act
            try
            {
                MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass(message);
                string actual = moodAnalyserClass.AnalyzeMood();

            }
            //Assert
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message );
            }
            
        }

        // Test Case :Given MoodAnalyse class name should return MoodAnalyse object.
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            
            object expected = new MoodAnalyserClass();
            object actual;
            //string message = null;
            try 
            {
                actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            }
            catch(CustomException ex)
            {
                throw new Exception(ex.Message);
            }   
            expected.Equals(actual);
        }


    }
}
