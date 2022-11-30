using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NestedLoop
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int i, num, count = 0;

            Console.WriteLine("Enter the Number For Prime Number");
            num = int.Parse(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            Console.WriteLine("Count :" + count);

            if(count==0 && num != 1)
            {
                Console.WriteLine(num + "Prime Number");
            }
            else
            {
                Console.WriteLine(num + "Not Prime Number");
            }
        }
    }
}
