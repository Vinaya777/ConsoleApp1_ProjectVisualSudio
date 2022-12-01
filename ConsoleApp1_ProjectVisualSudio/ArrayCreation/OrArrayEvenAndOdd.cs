using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class OrArrayEvenAndOdd
    {
        public void EvenAndOdd(int[] x)
        {
            int even = 0, odd = 0;
            int[] evenNo = new int[x.Length];
            int[] oddNo = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    evenNo[even] = x[i];
                    even++;
                }
                else
                {
                    oddNo[odd] = x[i];
                    odd++;
                }
            }
            Console.WriteLine("Total even number= " + even);
            Console.WriteLine("Even numbers: ");
            for (int i = 0; i < even; i++)
            {
                Console.WriteLine(evenNo[i]);

            }
            Console.WriteLine("Total Odd Numbers= " + odd);
            Console.WriteLine("Odd numbers: ");
            for (int i = 0; i < odd; i++)
            {
                Console.WriteLine(oddNo[i]);
            }
            static void main(string[] args)
            {
                Console.WriteLine("Enter The Size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[size];
                Console.WriteLine("Enter the Element: ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                OrArrayEvenAndOdd ode = new OrArrayEvenAndOdd();
               
                ode.EvenAndOdd(a);
            }

        }
    }
}