using System;
namespace sample
{
    class Car
    {
        public void display()
        {
            Console.Write("Car");
        }
    }
    class Maruti : Car
    {
        public void displaymaruti()
        {
            Console.Write("Maruti");
        }
    }
    class Mahindra: Car
    {
        public void displaymahindra()
        {
            Console.Write("Mahindra");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Maruti maruti = new Maruti();
            maruti.display();
            maruti.displaymaruti();

            Mahindra mahindra = new Mahindra();
            mahindra.display();
            mahindra.displaymahindra();
            Console.ReadKey();
        }
    }
}
