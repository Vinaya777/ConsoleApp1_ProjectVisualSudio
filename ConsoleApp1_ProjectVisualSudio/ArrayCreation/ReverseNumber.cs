using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class ReverseNumber
    {
        public int[] ReverseNum(int[] a)
        {
            int j = a.Length - 1;
            for(int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;
        }
      static void Main(string[] args)
        {
            int[] arr = { 6, 3, 12, 24, 48 };

            Console.WriteLine(string.Join(" ",arr));
            ReverseNumber rn = new ReverseNumber();
            int[] mrn = rn.ReverseNum(arr);
            Console.WriteLine(string.Join(" ",mrn));
        }
    }
}
