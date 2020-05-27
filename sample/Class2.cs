using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Class2
    {
        public static void main()
        {
            string[] array1 = Directory.GetFiles(@"D:\");
            Console.WriteLine("Files in the Directory");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
