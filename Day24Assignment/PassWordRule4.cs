﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24Assignment
{
    internal class PassWordRule4
    {
        public static void ValidatePassword()
        {
            
            
                Console.WriteLine("Enter a password");
                string password = Console.ReadLine();
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasNumber = new Regex(@"[0-9]+");
                var hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                var hasMiniChars = new Regex(@".{8,}");
                var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$");
                if (pattern.IsMatch(password))
                {
                    Console.WriteLine("Password is " + password);
                }
                else if (!hasMiniChars.IsMatch(password))
                {
                    Console.WriteLine ("Password should have minimum 8 characters");
                }
                else if (!hasLowerChar.IsMatch(password))
                {
                    Console.WriteLine ("Password should have at least 1 lower char");
                }
                else if (!hasUpperChar.IsMatch(password))
                {
                   Console.WriteLine ("Password should have at least one upper character");
                }
                else if (!hasNumber.IsMatch(password))
                {
                  Console.WriteLine ("Password should have at least one numeric number");
                }
                else if (!hasSpecialChar.IsMatch(password))
                {
                    Console.WriteLine ("Password should have at least one special char");
                }
                else
                {
                   Console.WriteLine ("Invalid Password");
                }
           
        }
    }
}
