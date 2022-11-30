using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class ElseIf3to9Divisible
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Number: ");
            n = int.Parse(Console.ReadLine());
            if (n % 3 == 0)
            {
                Console.WriteLine("Divisible by 3");

            }
            else if(n% 9 == 0)
            {
                Console.WriteLine("Number is divisible by 9");
            }
        }
        
    }
}
