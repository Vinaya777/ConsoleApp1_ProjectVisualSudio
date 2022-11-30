using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class FibonicesSeries
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int i = 1;
            int temp;
            while (i <= 10)
            {
                Console.WriteLine(a);
                temp = a + b;
               // Console.WriteLine(temp);
                a = b;
               // Console.WriteLine(b);
                b = temp;
                i++;
            }
        }
    }
}
