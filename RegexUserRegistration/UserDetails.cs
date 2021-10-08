using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserDetails
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        public void IsValidFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRST_NAME))
            {
                Console.WriteLine("FirstName is validated");
                return;
            }
            Console.WriteLine("FirstName is not validated");
        }
    }
}
