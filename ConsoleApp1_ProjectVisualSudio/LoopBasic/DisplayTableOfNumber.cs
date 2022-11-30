using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class DisplayTableOfNumber
    {
        static void Main(string[] args)
        {
            int j, n;
            Console.WriteLine("Enter the Value :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine(n * j);
            }
        }
    }
}
