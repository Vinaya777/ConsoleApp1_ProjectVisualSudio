using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class DivisibleBy5And3
    {
        static void Main(string[] args)
        {
            int num;
            num = 15;
            Console.WriteLine("Number  " + num);
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("Not divisible by 3 and 5");
            }
        }
    }
}
