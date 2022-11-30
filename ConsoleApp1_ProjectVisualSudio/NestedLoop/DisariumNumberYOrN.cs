using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NestedLoop
{
    class DisariumNumberYOrN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number For DisariumNumber");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int c = 0;
            while (num > 0)
            {
                num = num / 10;
                c++;
            }
            num = temp;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                int res = 1;
                for(int i = 1; i <= c; i++)
                {
                    res = res * r;
                }
                sum = sum + res;
                num = num / 10;
                c--;
            }
            if (sum == temp)
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
