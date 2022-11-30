using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.NewFolder.Loop
{
    class VowelSmallAphabetes
    {
        static void Main(String[] agrs)
        {
            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'||ch=='o'||ch=='i'||ch=='u'||ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
