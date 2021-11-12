using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        public string message;

        //default constructor
        public MoodAnalyserClass ()
        {
           
        }
        
        public MoodAnalyserClass(string message)
        {
            this.message = message;

        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                    return "Happy";
            }
            catch (NullReferenceException ex)
            {
                //return "happy";
                return "Message Should Not Be Null";
            } 
           
        }

        
    }
}
