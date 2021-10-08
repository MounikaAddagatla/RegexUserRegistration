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
            Console.ReadLine();
        }
    }
}
