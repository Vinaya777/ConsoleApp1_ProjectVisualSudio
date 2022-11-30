using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ArrayCreation
{
    class String
    {
        public char[] Acceptstring(char[] ch)
        {
            return ch;
        }
        static void Main(string[] args)
        {
            char[] c = { 't', 'r', 'u', 'O', 'k' };
            String s = new String();
             s.Acceptstring(c);
        }
    }
}
