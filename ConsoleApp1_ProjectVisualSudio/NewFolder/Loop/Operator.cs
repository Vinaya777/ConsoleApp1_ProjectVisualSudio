using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class Operator
    {
        static void Main(String[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);

            Console.WriteLine(a > b && a > c);
            Console.WriteLine(b > a || b > c);

            int x = 10;
            x += 2;
            x -= 3;
            x /= 4;
            x *= 2;
            Console.WriteLine(x);

        }
    }
}
