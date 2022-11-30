using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class SumOfEvenNumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter From Number:");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter To Number:");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            if (Number1 < Number2)
            {
                for (int i = Number1; i <= Number2; i++)
                {
                    if (i % 2 == 0)
                        sum += i;
                }
                Console.Write($"Sum of Even numbers from {Number1} to {Number2} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }

        }
    }
}
