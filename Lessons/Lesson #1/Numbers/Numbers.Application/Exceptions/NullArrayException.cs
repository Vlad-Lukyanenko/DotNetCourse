using System;

namespace Numbers.Application.Exceptions
{
    public class NullArrayException : Exception
    {
        public NullArrayException()
        {
        }

        public NullArrayException(string message)
            : base(message)
        {
        }

        public NullArrayException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
