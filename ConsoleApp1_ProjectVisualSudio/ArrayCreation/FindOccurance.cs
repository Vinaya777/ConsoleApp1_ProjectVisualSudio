using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
   
    class FindOccurance
    {

        static void Main(string[] args)
        {
            int[] a = { 2, 4, 8, 9, 7, 7, 2, 9 };
            for(int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;

                    }
                }
                if (isvisited == false)
                {
                    for(int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }

        }
    }
}
