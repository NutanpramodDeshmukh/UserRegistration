using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileFormat
{
    public static class Patterns
    {
        public static string PhoneNumberPattern = @"(^[0-9]{10}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Phone Number");
            Regex r1 = new Regex(Patterns.PhoneNumberPattern);
            Console.WriteLine(r1.IsMatch(Console.ReadLine()));
        }
    }
}
