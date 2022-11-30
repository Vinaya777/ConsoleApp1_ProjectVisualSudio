using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class EvenOdd
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");

            }
        }
    }
}
