using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class FactorOfNumber
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter The Number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factor Of Number is:" + n);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}