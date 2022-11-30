using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class DivisibleBy5
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the number: : ");
            num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0) && (num % 10 == 0)){
                Console.WriteLine("Number divisible by 5 " +num+"is divisbile by 10");

            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 " + num + "is divisible by 10");
            }
        }
    }
}
