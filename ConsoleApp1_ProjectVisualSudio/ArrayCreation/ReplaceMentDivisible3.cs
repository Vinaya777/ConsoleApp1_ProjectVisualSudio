using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class ReplaceMentDivisible3
    {

        public void acceptValue(int[] x)
        {
            Console.WriteLine("Enter array Value: ");
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        public void displayNoDivisibleBy3(int[] x)
        {
            Console.WriteLine("Number divisible by 3 are : ");
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] % 3 == 0)
                {
                    Console.WriteLine(x[i]+ " ");

                }
            }
        }

        public void SearchPresent(int [] x,int val)
        {
            bool isPresent = false;
            int count = 0;
            int[] b = new int[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == val)
                {
                    isPresent = true;
                    b[count] = i;
                    count++;
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size Of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[5];

            ReplaceMentDivisible3 rm = new ReplaceMentDivisible3();
            rm.acceptValue(a);
            rm.displayNoDivisibleBy3(a);
        }
    }
}
