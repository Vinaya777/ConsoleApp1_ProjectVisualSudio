using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class IfelseGreaterOrLess
    {
        static void Main (String[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First Number Greater");

            }
            else
            {
                Console.WriteLine("Second Number Greater");
            }
        }
    }
}
