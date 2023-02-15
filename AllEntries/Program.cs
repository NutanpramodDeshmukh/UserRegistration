using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllEntries
{
    public static class Patterns
    {
        public static string Firstname = "^[A-Z][a-z]{2,9}$";
        public static string LastName = "^[A-Z][a-z]{2,9}[ ][A-Z][a-z]{2,9}$";
        public static string Email = @"[a-z]{3,9}.?[a-z0-9]{3,8}[@][a-z]{3,8}[\.](com|org|in|net)$";
        public static string PhoneNumber = @"^[0-9]{2}[ ][0-9]{10,}$";
        public static string UserPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            Regex r1 = new Regex(Patterns.Firstname);
            Console.WriteLine(r1.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter Last Name");
            Regex r2 = new Regex(Patterns.LastName);
            Console.WriteLine(r2.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter Email Id");
            Regex r3 = new Regex(Patterns.Email);
            Console.WriteLine(r3.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter user valid Password");
            Regex r4 = new Regex(Patterns.UserPassword);
            //Console.WriteLine(r1.IsMatch(Console.ReadLine()));
            if (r4.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
