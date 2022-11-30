using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class MinNum
    {
        public int Min(int[] a)

        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 4, 9, 1 };
            MaxNum m = new MaxNum();
            Console.WriteLine("Max Of Array" + m.Max(arr));
        }
    }
}
