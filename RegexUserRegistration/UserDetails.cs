using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserDetails
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        // First Name Validation
        public void IsValidFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRST_NAME))
            {
                Console.WriteLine("FirstName is validated");
                return;
            }
            Console.WriteLine("FirstName is not validated");
        }
        public void IsValidLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LAST_NAME))
            {
                Console.WriteLine("lastname is validated");
                return;
            }
            Console.WriteLine("lastname is not validated");
        }
    }
}
