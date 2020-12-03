using System;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Windows;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no.");
            var num = Convert.ToByte(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
