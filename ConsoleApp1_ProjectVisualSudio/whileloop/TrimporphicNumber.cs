using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.whileloop
{
    class TrimporphicNumber
    {
        static void Main(string[] args)
        {
			int num = int.Parse(Console.ReadLine());

			int temp = num;

			int c = 0;

			while (num > 0)
			{
				num = num / 10;
				c++;

			}
			num = temp;
			int sq = num * num * num;
			Console.WriteLine(sq);
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(x);

            if (temp == num)
            {
				Console.Write("Trimorphic");
            }
            else
            {
				Console.WriteLine("Not Trimorphic");
            }
		}
    }
}
