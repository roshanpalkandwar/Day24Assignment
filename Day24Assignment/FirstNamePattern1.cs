using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24Assignment
{
    internal class FirstNamePattern1
    {
        public static void ValidateFirstName()
        {
            
            
                Console.WriteLine("Enter First Name");
                String firstName = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(firstName, pattern))
                {
                    Console.WriteLine("First Name : " + firstName);
                }
                else
                {
                   Console.WriteLine ("First name should be first letter capital and more then 2 characters");
                }
            
            
           

        }
    }
}
