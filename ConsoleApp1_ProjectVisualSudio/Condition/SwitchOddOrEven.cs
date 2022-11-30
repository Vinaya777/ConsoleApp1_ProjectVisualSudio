using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class SwitchOddOrEven
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter The Number: : ");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num % 2 == 0)
                // condition is checked with odd even so true and false condition
            { //n%2==0
                case true:
                    Console.WriteLine( "Even");
                    break;
                case false:
                    Console.WriteLine( "Odd");
                    break;
            }
        }
    }
}
