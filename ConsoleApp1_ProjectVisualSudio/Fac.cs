﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio
{
    class Fac
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;

            Console.Write("\n\n");
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}
