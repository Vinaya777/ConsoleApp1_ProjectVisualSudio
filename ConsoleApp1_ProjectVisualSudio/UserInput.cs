using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio
{
    class UserInput
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + 3);
        }
    }
}
