using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class DemoArray
    {
        static void Main(string[] args)
        {
            int x = 10;
            int[] myarray = new int[4];

            myarray[0] = 7;
            myarray[1] = 2;
            myarray[2] = 3;
            myarray[3] = 5;

            Console.WriteLine("Enter the array element");
            for(int i = 0; i < myarray.Length; i++)
            {
                /*int x = int.Parse(Console.ReadLine());
                myarray[i] = x;*/

                myarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("################################");
            for(int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
            Console.WriteLine("#################################");
            foreach(int element in myarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("####################################");
            Console.WriteLine(string.Join(",", myarray));
        }
    }
}
