using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class OddCountElement
    {

        public void Count(int [] arr)
        {

           // int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                   // sum += arr[i];
                    count++;
                    Console.WriteLine(arr[i]);
                }
                


            }
          //  Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Count: "+count);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            OddCountElement odd = new OddCountElement();
            odd.Count(a);


        }
    }
}
