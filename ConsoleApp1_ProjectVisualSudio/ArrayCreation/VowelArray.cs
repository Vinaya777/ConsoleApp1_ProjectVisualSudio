using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class VowelArray
    {
        public char[] chengeArray(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    //  ch[i] = (char)(ch[i] - 32);
                    Console.WriteLine("Small");
                }
                else if (ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    //ch[i] = (char)(ch[i] + 32);
                    Console.WriteLine("Large");
                }
                else
                {
                    //ch[i] = ch[i];
                    Console.WriteLine("Consonant");
                }
            }
            return ch;

        }
        static void Main(string[] args)
        {

            char[] c = { 't', 'R', 'U', 'a', 'l', 'O', 'i', 'I', 'A', 'a', 'U' };
            Console.WriteLine(string.Join(" ", c));
            VowelArray t = new VowelArray();
            char[] myt = t.chengeArray(c);

            Console.WriteLine(string.Join(" ", myt));
        }
    }
}
