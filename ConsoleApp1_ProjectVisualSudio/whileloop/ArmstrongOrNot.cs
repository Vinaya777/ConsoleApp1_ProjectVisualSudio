using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class ArmstrongOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to check");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);num = num / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Is A Armstrong Number");

            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }
        }
    }
}
