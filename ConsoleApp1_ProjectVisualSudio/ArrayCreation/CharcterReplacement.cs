using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class CharcterReplacement
    {
        public char[] ChanArray(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
                else
                {
                    ch[i] = ch[i];
                }

            }
            return ch;
        }
        public void ReplacementChar(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'y' || ch[i] == 'Y' || ch[i] == 'z' || ch[i] == 'Z')
                {
                    ch[i] = (char)(ch[i] - 24);
                }
                else
                {
                    ch[i] = (char)(ch[i] + 2);
                }
            }
            Console.WriteLine("****************************************" + string.Join(" ", ch));
        }
        static void Main(string[] args)
        {

            char[] c = { 't', 'P', 'Y', 'j', 'g', 'w', 'Q' };
            Console.WriteLine(string.Join(" ", c));
            CharcterReplacement cr = new CharcterReplacement();
            char[] mychar = cr.ChanArray(c);
            cr.ReplacementChar(c);

        }


    }
  }
