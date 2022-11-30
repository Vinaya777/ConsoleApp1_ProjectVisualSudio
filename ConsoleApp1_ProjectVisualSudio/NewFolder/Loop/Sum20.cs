using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class Sum20
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i <= 20)
            {
                sum = sum + i;
                if (sum > 10)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
