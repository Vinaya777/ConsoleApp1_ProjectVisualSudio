using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class UsingWhileloop1to20
    {
        static void Main(string[] args)
        {
            int num, sum = 0, i = 1;
            Console.WriteLine("Value Of Number");
            num = int.Parse(Console.ReadLine());

            while (i <= num)
            {
                sum = num + i;
                num = i + 2;
            }
            Console.WriteLine(sum);

        }
    }
}
