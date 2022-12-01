using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            /*for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr[0]);*/
           /* foreach( int data in arr)
                Console.WriteLine(data);*/


           for(int i=arr.Length-1;i>=0;i--)
                Console.WriteLine(arr[i]);
        }
    }
}
