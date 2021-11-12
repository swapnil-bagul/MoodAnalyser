using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyseFactory
    {
        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = "." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if(result .Success )
            {
                try
                {
                    //creates an assembly
                    Assembly excuting = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = excuting.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (Exception ex )
                {
                    throw new CustomException(CustomException.ExpectionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExpectionType.CONSTRUCTOR_NOT_FOUND , "Constructor is not Found");
            }
        }
    }
}
