using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class DisplayNumber1to50SkipDivisible5
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i < 50; i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(" " + i);
                    continue;
                    
                }
            }
        }
    }
}
