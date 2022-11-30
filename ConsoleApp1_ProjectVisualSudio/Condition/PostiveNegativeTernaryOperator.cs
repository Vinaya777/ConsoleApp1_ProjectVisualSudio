using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class PostiveNegativeTernaryOperator
    {
        static void Main(String[] args)
        {
            int a ;
            Console.WriteLine("Enter the Number");
            a = int.Parse(Console.ReadLine());
           
            String s = (a < 0) ? "Number is negative " : (a > 0) ? "Number is postive" : " Zero ";
            Console.WriteLine(s);
            
            

        }
    }
}
