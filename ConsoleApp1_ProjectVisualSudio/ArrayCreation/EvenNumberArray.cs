using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class EvenNumberArray
    {

        public void DisplayEven(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[]a=new int[5];
            Console.WriteLine("Enter the array elements");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("##########");
            EvenNumberArray myobj = new EvenNumberArray();
            myobj.DisplayEven(a);
        }
    }
}
