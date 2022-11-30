using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class Calculate1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("SUM: : " + sum);
        }
    }
}
