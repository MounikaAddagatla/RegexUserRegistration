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
        const string EMAIL_ID = "^[A-Z0-9a-z]+([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        const string PHN_NUM = "^([+][0-9]{2}\\s[6-9]{1}[0-9]{9}$)";
        const string PASSWORD = "^[A-Z]{1}([1-9]{1,}?[a-zA-Z]{1,}(?=.*[!*@#$%^&+=]).*?){1,}.{4,}?$";
        // First Name Validation
        public bool ToCheckName(string name) => (Regex.IsMatch(name, FIRST_NAME));

        public bool ToCheckLastName(string lastName) => (Regex.IsMatch(lastName, LAST_NAME));

        public bool ToCheckMail(string mail) => (Regex.IsMatch(mail, EMAIL_ID));

        public bool ToCheckNumber(string number) => (Regex.IsMatch(number, PHN_NUM));

        public bool ToCheckPassword(string password) => (Regex.IsMatch(password, PASSWORD));
    }
}
