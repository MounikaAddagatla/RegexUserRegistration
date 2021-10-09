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
       // const string SUPPORTED_DOMAIN = "@bl.co.";
        const string EMAIL_ID = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
       
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
        public void IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_ID))
            {
                Console.WriteLine("EMAIL_ID is validated");
                return;
            }
            Console.WriteLine("EMAIL_ID is not validated");
        }
    }
}
