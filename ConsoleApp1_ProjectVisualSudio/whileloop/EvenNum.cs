using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class EvenNum
    {
        static void Main(string[] args)
        {
           /* int i = 1;
            while (i <= 6)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                    continue;

                }
                Console.WriteLine(i);
                i++;*/
           for(int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break;

                }
                Console.WriteLine(i);
            }
            }
        }
    }

