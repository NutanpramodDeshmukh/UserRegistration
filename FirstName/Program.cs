using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FirstName
{
    public static class Patterns
    {
        public static string FirstName = @"^[A-Z][a-z]{3,9}$";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            Regex r1 = new Regex(Patterns.FirstName);
            Console.WriteLine(r1.IsMatch(Console.ReadLine()));
        }
    }
}