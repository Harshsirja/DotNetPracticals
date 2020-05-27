using System;
namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1(); //This will print Pattern_1
            Console.WriteLine();
            pattern2(); //This will print Pattern_2
            Console.WriteLine();
            pattern3(); //This will print Pattern_3
            Console.Read();
        }
        static void pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

