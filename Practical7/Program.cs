using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();
            Console.WriteLine(Double.Parse(number) + "C = " + CTOF(Double.Parse(number)) + "F");
            Console.WriteLine(Double.Parse(number) + "F = " + FTOC(Double.Parse(number)) + "C");
            Console.ReadLine();
        }

        static double CTOF(double c)
        {
            return ((9.0/5.0)*c) + 32.0;
        }

        static double FTOC(double f)
        {
            return ((f-32.0)*(5.0/9.0));
        }
    }


}
