using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;
            Console.WriteLine("Enter For Magic Number");
            num = int.Parse(Console.ReadLine());

            temp = num;

            while (temp != 0)
            {
                rem = temp % 10;
                sum = sum + rem;
                temp = temp / 10;

            }
            temp = sum;

            if (sum == 1)
            {
                Console.WriteLine(" Number is Magical"+num);
            }
            else
            {
                Console.WriteLine("Number is Not Magical" + num);
            }
        }
    }
}
