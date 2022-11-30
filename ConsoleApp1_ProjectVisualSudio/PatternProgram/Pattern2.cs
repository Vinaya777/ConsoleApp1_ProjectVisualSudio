using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.PatternProgram
{
    class Pattern2
    {
        static void Main(string[] args)
        {

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern7
    {
        static void Main(string[] args)
        {

            for (char i = 'D'; i <= 'A'; i--)
            {
                for (char j = 'D'; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
