using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.LoopBasic
{
    class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * num * num;
            Console.WriteLine(result);
            int dig1 = result % 10;
            Console.WriteLine("first dig" + dig1);
            int ldig2 = num % 10;
            Console.WriteLine("last dig" + ldig2);
        }
    }
}
