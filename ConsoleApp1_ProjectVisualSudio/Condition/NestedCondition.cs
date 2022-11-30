using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class NestedCondition
    {
        static void Main(String[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Eneter the Num 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Num 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter the Num 3");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("Number one is greater");

            }else if(num2> num3 && num2>num3)
            {
                Console.WriteLine("Number two is greater");

            }
            else
            {
                Console.WriteLine("Number three is greater");
            }


        }
        
    }
}
