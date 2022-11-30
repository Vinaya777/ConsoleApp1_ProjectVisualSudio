using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.Condition
{
    class Vowels
    {
        static void Main(String[] args)
        {
           
            Console.WriteLine("Enter the Character: : ");
            String ch = Console.ReadLine();
            
            switch (ch)
            {
                case "a":
                    Console.WriteLine("Vowel");
                    break;
                case "e":
                    Console.WriteLine("Vowel");
                    break;
                case "i":
                    Console.WriteLine("Vowel");
                    break;
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                case "o":
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Console");
                    break;

            }

        }
    }
}
