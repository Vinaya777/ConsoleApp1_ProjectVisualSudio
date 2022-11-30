using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class MaxNum
    {

        public int Max(int[] a)

        {
            int max = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
     
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 4, 9, 1 };
            MaxNum m = new MaxNum();
            Console.WriteLine("Max Of Array"+m.Max(arr));
           
        }
    }
}
