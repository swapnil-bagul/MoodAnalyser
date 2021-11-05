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
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Message is null");
                return "happy";
            } 
           
        }
       
    }
}
