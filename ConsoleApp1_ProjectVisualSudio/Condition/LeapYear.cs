using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class LeapYear
    {
        static void Main(String[] args)
        {
            int year;
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());
            if(((year % 4 == 0) && (year % 100 != 0)) || ((year % 400 == 0)))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
