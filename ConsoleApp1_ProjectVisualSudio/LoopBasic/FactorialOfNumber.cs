using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class FactorialOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of Number " + fact);
        }
    }
}
