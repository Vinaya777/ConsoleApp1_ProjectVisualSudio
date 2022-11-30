using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class NumberDivisibleBy3Or9
    {
        static void Main(String[] args)
        {
            int num = 769;
            if ((num % 3 == 0) && (num % 9 == 0))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
