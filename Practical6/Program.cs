using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();
            Console.WriteLine(Double.Parse(number) + "Rupee = " + RuppeToUSDollar(Double.Parse(number)) + "$");
            Console.WriteLine(Double.Parse(number) + "$ = " + RuppeToUSDollar(Double.Parse(number)) + "Rupee");
            Console.ReadLine();
        }

        static double RuppeToUSDollar(double rupee)
        {
            return rupee / 71.84;
        }

        static double USDollarToRupee(double dollar)
        {
            return dollar * 71.84;
        }


    }
}
