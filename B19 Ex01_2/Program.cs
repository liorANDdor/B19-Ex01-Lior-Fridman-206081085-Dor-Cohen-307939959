using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_2
{
	public class Program//
	{
		public static void Main()
		{
			PrintPyramid(5, 0);
		}
		public static void PrintPyramid(int i_sizeOfPyramid, int i_numOfSpaces)
		{
			if (i_sizeOfPyramid > 1)
			{
				for (int i = 0; i < i_sizeOfPyramid; i++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
				for (int i = 0; i < i_numOfSpaces + 1; i++)
				{
					Console.Write(" ");
				}
				PrintPyramid(i_sizeOfPyramid - 2, i_numOfSpaces + 1);
			}
			if (i_sizeOfPyramid != 1)
				for (int i = 0; i < i_numOfSpaces; i++)
				{
					Console.Write(" ");
				}
			for (int i = 0; i < i_sizeOfPyramid; i++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
		}
	}
}
