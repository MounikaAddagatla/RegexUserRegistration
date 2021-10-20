using System;
using System.Collections.Generic;
using System.Text;

namespace RegexUserRegistration
{
    class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_ENTRY

        }
        private readonly ExceptionType type;
        public CustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
