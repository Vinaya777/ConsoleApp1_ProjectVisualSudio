using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digt = num % 10;
                sum = sum + digt;
                num = num / 10;

            }
            Console.WriteLine(+sum);
        }
    }
}
