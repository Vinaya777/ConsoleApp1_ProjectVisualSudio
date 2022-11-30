using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProjectVisualSudio.ClassAndObjApproch
{
    class TestData
    {
		public int getData(int i)
		{
			return 1;
		}

		public long getData()
		{
			return 0;
		}
        static void Main(string[] args)
        {
			TestData td = new TestData();
			Console.WriteLine(td.getData());
        }
	}
}
