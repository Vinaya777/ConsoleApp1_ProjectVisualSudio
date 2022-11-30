using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class GretestFromThreeNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the 1st Number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number : ");
            int c = int.Parse(Console.ReadLine());

            String s = a > b && a > c ? a + "is greatest number" : b > a && b > c ? b + "is greatest number" : c + "is greatest";
            Console.WriteLine(s);
        }
    }
}
