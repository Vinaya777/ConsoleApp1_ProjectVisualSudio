using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class ArithmaticOperation
    {
		public float addNumber(float n1, float n2)
		{
			return n1 + n2;
		}

		public float subNumber(float n1, float n2)
		{
			return n1 - n2;
		}

		public float mulNumber(float n1, float n2)
		{
			return n1 * n2;
		}

		public float divNumber(float n1, float n2)
		{
			return n1 / n2;
		}


		static void Main(string[] args)
        {
			ArithmaticOperation o = new ArithmaticOperation();
			float result1 = o.addNumber(23, 2.6f);
            Console.WriteLine("Addition: "+result1);
			float result2 = o.subNumber(5, 5.3f);
            Console.WriteLine("Substraction: "+result2);
			float result3 = o.mulNumber(7, 8.6f);
            Console.WriteLine("Multiplication: "+result3);
			float result4 = o.divNumber(8, 6.7f);
            Console.WriteLine("Division: "+result4);
		}
    }
}
