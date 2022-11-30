using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class MaxNumberUsingTernary
    {
        static void Main(String[] args)
        {
            int n1, n2, max;
            Console.WriteLine("enter 1st number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            n2 = int.Parse(Console.ReadLine());
            max = (n1 > n2) ? n1 : n2 ;
            Console.WriteLine(" ");
            Console.WriteLine("Max number between " + n1 + " and " + n2 + " is " + max + " ");
           }
    }
}
