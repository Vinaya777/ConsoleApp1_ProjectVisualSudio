using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Dowhile
{
    class MagicNumber
    {static void Main(string[] args)
        {
            int magicnumber = 66;
            while (true)
            {
                Console.WriteLine("Enter the Number");
                int num = int.Parse(Console.ReadLine());
                if (num > magicnumber)
                {
                    Console.WriteLine("Number is greater then gussing number");
                    continue;

                }
                else if (num < magicnumber)
                {
                    Console.WriteLine("Number is lesser than gussing number");
                    continue;
                }
                else
                {
                    Console.WriteLine("WOW!!!!!!!!!!!!!!!!! you gussed it ,it's correct number");
                    break;
                }
            }
        }
    }
}
