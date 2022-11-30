using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio
{
    class UnaryOpreator
    {
        static void Main(String[] args)
        {
            int a = 2;
            int b = 2;
            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);
            x = --a - --b;
            Console.WriteLine(x + " " + a + " " + b);
            x = a++ + b--;
            Console.WriteLine(x + " " + a + " " + b);
            x = ++a + ++b + a;
            Console.WriteLine(x + " " + a + " " + b);

          /*  int x = ++a + b++;
            Console.WriteLine(x + " " + a + " " + b);

            int b = a++ + b++ + a;
            Console.WriteLine(x + " " + a + " " + b);*/
        }
    }
}
