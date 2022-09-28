using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24Assignment
{
    internal class ValidateLastName2
    {
        public static void ValidateLastName()
        {
            
            
                Console.WriteLine("Enter Last Name");
                String lastName = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(lastName, pattern))
                {
                    Console.WriteLine("First Name : " + lastName);
                }
                else
                {
                  Console.WriteLine ("Last name should be first letter capital and more then 2 characters");
                }
            
           

        }
    }
}
