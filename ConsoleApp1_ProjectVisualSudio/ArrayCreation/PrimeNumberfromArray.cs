using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class PrimeNumberfromArray
    {

        public void FindPrime(int[] a)
        {
            Console.WriteLine("Prime Number from array");
            for (int i = 0; i < a.Length; i++)
            {
                bool flag = true;
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(a[i] + " Is Prime");
                }
                else
                {
                    Console.WriteLine(a[i] + " Not Prime");
                }
            }
            static void Main(String[] args)
            {
                int[] a = new int[10];
                Console.WriteLine("Enter Array Element");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                PrimeNumberfromArray pn = new PrimeNumberfromArray();
                pn.FindPrime(a);


            }
        }
    }

}