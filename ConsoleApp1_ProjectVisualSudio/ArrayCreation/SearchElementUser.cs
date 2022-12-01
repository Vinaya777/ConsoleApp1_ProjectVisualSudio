using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    
    class SearchElementUser
    {
        public bool IsPresent(int[] a, int n)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Value to be searched");
            int num = int.Parse(Console.ReadLine());
            SearchElementUser s = new SearchElementUser();
            Console.WriteLine(string.Join(" ",arr));
            bool isCheck = s.IsPresent(arr, num);

            if (isCheck)
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
