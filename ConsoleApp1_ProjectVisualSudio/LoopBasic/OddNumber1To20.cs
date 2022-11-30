using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class OddNumber1To20
    {
        static void Main(string[] args)
        {
            int i;//sum=0;
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                   /* sum = i + 1;
                    Console.WriteLine(sum);*/
                }
            }

        }
    }
}
