using System;

namespace Numbers.Application.Exceptions
{
    public class EmptyArrayException : Exception
    {
        public EmptyArrayException()
        {
        }

        public EmptyArrayException(string message)
            : base(message)
        {
        }

        public EmptyArrayException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
