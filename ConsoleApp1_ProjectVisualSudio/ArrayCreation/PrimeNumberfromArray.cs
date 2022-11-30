using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class PrimeNumberfromArray
    {
        static void Main(String[] args)
        {
            int count = 0;
           
            Console.WriteLine("All number list");
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 18 };
            
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i]; j++)
                    if (j == num[i])
                    {

                        count++;
                        break;

                    }

                if (count == 2)
                {
                    Console.Write("Is Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
            

        }
    }
}

