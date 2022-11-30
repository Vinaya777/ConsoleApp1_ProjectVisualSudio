using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class OddNumber1To20
    {
        static void Main(string[] args)
        {
            /*int count = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }*/


            int sum = 0, i = 1;
            Console.WriteLine("Enter the Value");
            int num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                sum = sum+i;


            }
        }
    }
}
