using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class SquareOfNumber
    {

        public void ArrayValue(int[] x)
        {
            Console.WriteLine("Array Value :");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
        }

        public void squareOfArray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                int j = 1, pow = 1;
                while (j <= 2)
                {
                    pow *= a[i];
                    j++;
                }
                Console.WriteLine("square of"+ a[i]+ "is"+ pow);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Size Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            SquareOfNumber sqn = new SquareOfNumber();
            sqn.ArrayValue(a);
            sqn.squareOfArray(a);


        }
    }
}
