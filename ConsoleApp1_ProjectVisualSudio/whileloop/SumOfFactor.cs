using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class SumOfFactor
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;


                }
                Console.WriteLine("Sum Fact=" + sum);

            }
        }
    }
}
