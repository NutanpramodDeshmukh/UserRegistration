using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidation
{
    public static class Patterns
    {
        public static string EmailPattern = @"[a-z]{3,7}.?[a-z0-9]{3,8}@[a-z]{3,8}.(com|in)$";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Email Address");
            Regex r1 = new Regex(Patterns.EmailPattern);
            Console.WriteLine(r1.IsMatch(Console.ReadLine()));
        }
    }
}
