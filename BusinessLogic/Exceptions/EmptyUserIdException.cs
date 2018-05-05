using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Exceptions
{
    public class EmptyUserIdException : Exception
    {
        public EmptyUserIdException() : base()
        {
        }

        public EmptyUserIdException(string message) : base(message)
        {
        }
    }
}
