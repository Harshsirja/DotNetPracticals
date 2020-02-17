using System;
namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            String infix = "a+b*(c-d)";
            String postfix;
            myclass.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : " + postfix);
            Console.Read();
        }
    }
}