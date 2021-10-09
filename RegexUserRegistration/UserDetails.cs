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
        const string PHN_NUM = "^([+][0-9]{2}\\s[6-9]{1}[0-9]{9}$)";
        const string PASSWORD = "^.{8,}?$";
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
        public void IsValidPhnNum(string phnNum)
        {
            if (Regex.IsMatch(phnNum, PHN_NUM))
            {
                Console.WriteLine("PHN_NUM is validated");
                return;
            }
            Console.WriteLine("PHN_NUM is not validated");
        }
        public void IsValidPassWord(string passWord)
        {
            if (Regex.IsMatch(passWord, PASSWORD))
            {
                Console.WriteLine("PASSWORD is validated");
                return;
            }
            Console.WriteLine("PASSWORD is not validated");
        }
    }
}
