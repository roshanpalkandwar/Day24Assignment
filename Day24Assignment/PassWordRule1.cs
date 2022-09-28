using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24Assignment
{
    internal class PassWordRule1
    {
        public static void ValidatePassword()
        {
            
            
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                var hasLowerChar = new Regex("^([a-z]){8,}$");

                if (!hasLowerChar.IsMatch(password))
                {
                    Console.WriteLine ("Password is not valid... Password should have minimum 8 characters");
                }
                else
                {
                    Console.WriteLine("Password : " + password);
                }
            
        }
    }
}
