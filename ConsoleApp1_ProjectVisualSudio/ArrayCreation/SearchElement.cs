using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 9, 4, 3, };
            Console.WriteLine("Enter the Value");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("Present");
                }
                else
                {
                    Console.WriteLine("Not Present");
                }
            }


        }
    }
}
