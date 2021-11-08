using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MoodAnalyser
{
    public class CustomException:Exception 
    {
        public ExpectionType Type;

        // enum is user-defined value type used to represent a list of named interger constants
        // here it is used for exception type list and is is constant

        public enum ExpectionType
        {
            NULL_TYPE_EXCEPTION,
            EMPTY_TYPE_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND
        }
        //Create Constructor
        public CustomException (ExpectionType type ,string message): base (message )
        {
            this.Type = type;
        }
    }
}
