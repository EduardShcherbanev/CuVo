using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Exceptions
{
    public class EmptySpellingException : Exception
    {
        public EmptySpellingException() : base()
        {
        }

        public EmptySpellingException(string message) : base(message)
        {
        }
    }
}
