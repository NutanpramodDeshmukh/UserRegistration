using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastName
{
    public static class Patterns
    {
        public static string LastName = @"^[A-Z][a-z]{3,9}$";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Last Name");
            Regex r1 = new Regex(Patterns.LastName);
            Console.WriteLine(r1.IsMatch(Console.ReadLine()));
        }
    }
}
