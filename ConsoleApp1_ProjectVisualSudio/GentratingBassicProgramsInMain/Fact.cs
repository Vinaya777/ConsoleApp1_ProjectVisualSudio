using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.GentratingBassicProgramsInMain
{
    class Fact
    {
        public int SumOfFactor(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Fact f = new Fact();
            int result = f.SumOfFactor(8);
            Console.WriteLine("Sum Of Factor=" + result);

        }
    }
}
