﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordRule4
{
    public static class Patterns
    {
        public static string UserPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter user valid Password");
            Regex r1 = new Regex(Patterns.UserPassword);
            //Console.WriteLine(r1.IsMatch(Console.ReadLine()));
            if (r1.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
