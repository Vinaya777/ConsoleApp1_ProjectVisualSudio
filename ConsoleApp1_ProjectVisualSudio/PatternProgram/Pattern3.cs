using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.PatternProgram
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
  
    }

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + "*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class PatternAlphabets
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'F'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
