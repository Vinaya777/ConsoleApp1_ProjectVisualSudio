using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class Character
    {
        static void Main(string[] args)
        {
            char[] ch = { 'r', 'y', 'k', '*', '#', '@' };
            char[] ch1 = new char[4];
            Console.WriteLine("Enetr the Character Value");
            for(int i = 0; i < ch1.Length; i++)
            {
                ch1[i] = Convert.ToChar(Console.ReadLine());
            }


            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            for(int i = 0; i < ch1.Length; i++)
            {
                Console.WriteLine(ch1[i]);
            }
            foreach(char c in ch1)
            {
                Console.WriteLine(c+" !@!@!@!@!@!@!@!@!@!@!@!@!@!@!@!@!!@!!@!@!@!@!@");
            }
        }
    }
}
