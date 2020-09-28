using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Debug.WriteLine("Hello World!");

            int x;
            int y;
            x = 3;
            y = 4;
            int sum = x + y;
            Console.WriteLine("x + Y is" + sum);
            Debug.WriteLine("x + Y is" + sum);
        }
    }
}
