using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class PowerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the exponenet");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;
            for(int i = 1; i <= expo; i++)
            {
                power = power * baseNumber;

            }
            Console.WriteLine(power);
        }
    }
}
