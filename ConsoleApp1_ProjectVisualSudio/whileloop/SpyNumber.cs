using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
            int m = n;
            int sum = 0, prod = 1;

            while (n != 0)
            {
                int d = n % 10;
                sum = sum + d;
                prod = prod * d;
                n = n / 10;
            }
            if (sum == prod)
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
