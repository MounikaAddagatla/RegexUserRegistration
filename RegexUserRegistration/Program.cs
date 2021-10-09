using System;
using System.IO;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            // first name regex Validation//
            UserDetails user = new UserDetails();
            user.IsValidFirstName("Mounika");
            // for last name        
            user.IsValidLastName("Addagatla");
            // for valid email
            user.IsValidEmail("abc.xyz@bl.co.in");
            // for valid phn number
            user.IsValidPhnNum("+91 6304727468");
            // for valid password 
            user.IsValidPassWord("A1assss@s");
            
            /// reading data from the text file valid email id///
            string filepath = @"E:\RegexUserRegistration\RegexUserRegistration\Emailds\IsValidEmail.txt";
            using (StreamReader file = new StreamReader(filepath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    UserDetails emailUser = new UserDetails();
                    Console.WriteLine(ln+ " : ");
                    user.IsValidEmail(ln);
                    Console.WriteLine();
                }
                file.Close();

            }
            Console.ReadLine();
        }
    }
}
