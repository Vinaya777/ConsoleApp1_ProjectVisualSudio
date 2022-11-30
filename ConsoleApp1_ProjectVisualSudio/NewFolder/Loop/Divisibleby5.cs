using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class Divisibleby5
    {
        static void Main(String[] args)
        {
            /*int i = 50;
            while (i <= 50)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }*/
            for(int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                    
                }
                i++;
                Console.WriteLine(i);
            }
        }

    }
}
