using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        public string message;

        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
                return "HAPPY";
        }

    }
}
