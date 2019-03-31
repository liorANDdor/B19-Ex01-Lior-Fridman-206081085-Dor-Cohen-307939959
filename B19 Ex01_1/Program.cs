using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_1
{
	class Program
	{
		public static void Main()
		{
			RunApplication();
		}
		public static void RunApplication()
		{
			int numInBinaryInput = GetInputFromUserInBinary();
			int userInputInDecimal = BinaryToDecimalConvertor(numInBinaryInput);
			Console.WriteLine(userInputInDecimal);

		}
		public static int GetInputFromUserInBinary()
		{
			int numInBinary;
			string userInput = Console.ReadLine();
			numInBinary = int.Parse(userInput);
			return numInBinary;
		}
		public static int BinaryToDecimalConvertor(int i_numInBinaryInput)
		{
			int numInDecimal = 0;
			int lastDigit;
			int powOf2ToMul;
			for(int i = 0; i < 8; i++)
			{
				lastDigit = i_numInBinaryInput % 10;
				powOf2ToMul = (int) Math.Pow(2, i);
				numInDecimal = numInDecimal + (powOf2ToMul * lastDigit);
				i_numInBinaryInput = i_numInBinaryInput / 10;
			}
			return numInDecimal;
		}
	}
}
