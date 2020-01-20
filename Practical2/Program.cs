using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            long mobile;

            do {
                Console.WriteLine("What is your Name: ");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name,"^[a-zA-Z]+$"));
            do {
                Console.WriteLine("Where are you from: ");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, "^[a-zA-Z]+$"));
            Console.WriteLine("Hello " + name + " from country " + country);
            Console.ReadLine();
        }
    }
}
