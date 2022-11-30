using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NestedLoop
{
    class Table
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(a + " * " + (i) + " = " + (a * (i)));
                }
                Console.WriteLine("----------");
            }
        }
    }
}
