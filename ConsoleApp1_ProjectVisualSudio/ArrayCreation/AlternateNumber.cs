using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class AlternateNumber
    {

        public void AlternateValue(int[] x)
        {
            Console.WriteLine("Aalternate Elemnet are: ");
            for(int i = 0; i < x.Length; i += 2)
            {
                Console.WriteLine(x[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Size Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];

            Console.WriteLine("Enter the array");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            AlternateNumber an = new AlternateNumber();
            an.AlternateValue(arr);
            
        }
    }
}

