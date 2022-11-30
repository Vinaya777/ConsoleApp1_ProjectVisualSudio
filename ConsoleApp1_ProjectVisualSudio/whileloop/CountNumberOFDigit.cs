using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class CountNumberOFDigit
    { static void Main(string [] args)
        {
            int count=0;
            Console.WriteLine("Enter the Number");
            long n = long.Parse(Console.ReadLine());

            while (n != 0)
            {
                n = n / 10;
                count++;

            }
            Console.WriteLine(n);
        }
    }
}
