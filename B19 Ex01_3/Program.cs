using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_3
{
	class Program
	{
		public static void Main()
		{
			int sizeOfPyramid;
			sizeOfPyramid = GetSizeOfPyramidFromUser();
			B19_Ex01_2.Program.PrintPyramid(sizeOfPyramid,0);
		}
		public static int GetSizeOfPyramidFromUser()
		{
			Console.Write("Please Enter the size of pyramid you wish for: ");
			string inputOfSizeOfPyramid = Console.ReadLine();
			int  sizeOfPyramidToInt;
			bool v_checkIfInputCorrect;
			v_checkIfInputCorrect = int.TryParse(inputOfSizeOfPyramid,out sizeOfPyramidToInt);
			if (sizeOfPyramidToInt < 0)
			{
				v_checkIfInputCorrect = false;
			}
			while (!v_checkIfInputCorrect)
			{
				Console.Write("Your input is invalid, try again: ");
				inputOfSizeOfPyramid = Console.ReadLine();
				v_checkIfInputCorrect = int.TryParse(inputOfSizeOfPyramid, out sizeOfPyramidToInt);
				if (sizeOfPyramidToInt < 0)
				{
					v_checkIfInputCorrect = false;
				}
			}
			if (sizeOfPyramidToInt % 2 == 0)
			{
				return sizeOfPyramidToInt + 1;
			}
			else
			{
				return sizeOfPyramidToInt;
			}
		}
	}
}
