using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class UserInput3Or9DivisibleNum
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the number :");
            num = int.Parse(Console.ReadLine());
           

            if ((num % 5 == 0) || (num % 9 == 0))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
