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
			bool ch = CheckIfTheNumberSeriesIsAscending(162345);
			int[] arr = { 3, 2, 3, 5 };
			float av = CalculateAverage(arr, 4);
			Console.WriteLine(av);
			Console.WriteLine(ch);

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
		public static bool CheckIfTheNumberSeriesIsAscending (int i_numberToCheck)
		{
			bool v_checkNumIsAscending = true;
			int lastDigit, oneDigitBeforeLast;
			while (i_numberToCheck > 9 && v_checkNumIsAscending)
			{
				lastDigit = i_numberToCheck % 10;
				oneDigitBeforeLast = (i_numberToCheck / 10) % 10;
				if(oneDigitBeforeLast >= lastDigit)
				{
					v_checkNumIsAscending = false;
				}
				i_numberToCheck = i_numberToCheck / 10;
			}
			return v_checkNumIsAscending;
		}
		public static float CalculateAverage(int [] i_arrInput,int i_numOfElements)
		{
			float averageOfArrElements = 0;
			int sumOfArrElements = 0;
			for(int i=0;i<i_numOfElements;i++)
			{
				sumOfArrElements += i_arrInput[i];
			}
			averageOfArrElements = (float)sumOfArrElements / i_numOfElements;
			return averageOfArrElements;
		}
	}
}
