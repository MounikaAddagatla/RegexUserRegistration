using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class Validation
    {
        public bool checkIfValid(string regex, string input)
        {
            var matchInput = Regex.Match(input, regex);
            if (matchInput.Success)
            {
                return true;
            }
            throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid Input");
        }
    }
}
