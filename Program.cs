using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = Hello();
            Console.WriteLine(h);

            int s = Sum();
            Console.WriteLine(s);

            Method1();
            Method2();
            Method3();
            
        }

        static string Hello()
        {
            return "Hello World";
        }

        static int Sum()
        {
            int x = 256;
            int y = 521;
            int z = x + y;
            return z;
        }

        static void Method1()
        {
            Console.WriteLine("Have a");
        }

        static void Method2()
        {
            Console.WriteLine("Nice");
        }

        static void Method3()
        {
            Console.WriteLine("Day");
        }
    }
}
