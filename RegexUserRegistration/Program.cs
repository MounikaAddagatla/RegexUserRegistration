using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            // first name regex Validation//
            UserDetails firstName = new UserDetails();
            firstName.IsValidFirstName("Mounika");
            // for last name
            UserDetails lastName = new UserDetails();
            lastName.IsValidLastName("Addagatla");
            UserDetails email = new UserDetails();
            email.IsValidEmail("abc.xyz@bl.co.in");
            Console.ReadLine();
        }
    }
}
