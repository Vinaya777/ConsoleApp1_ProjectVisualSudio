using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class PositiveOrNegativeNum
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            /*Console.WriteLine("Enter the 2nd Number");
            num = int.Parse(Console.ReadLine());*/

            if (num > 0)
            {
                Console.WriteLine("Positve Number");
            }
            else if(num < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero Number");
            }
        }
    }
}
