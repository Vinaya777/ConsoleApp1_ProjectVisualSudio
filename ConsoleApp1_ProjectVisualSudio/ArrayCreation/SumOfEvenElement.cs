﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class SumOfEvenElement
    {
        public void DisplayEven(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                    Console.WriteLine(arr[i]);
                }

                
            }
            Console.WriteLine("Sum : "+sum);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SumOfEvenElement sumeven = new SumOfEvenElement();
            sumeven.DisplayEven(a);
        }
    }
}
