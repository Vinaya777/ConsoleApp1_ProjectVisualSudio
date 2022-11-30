using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class TernaryOperatorEvenOddcs
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Number ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }
    }
}
