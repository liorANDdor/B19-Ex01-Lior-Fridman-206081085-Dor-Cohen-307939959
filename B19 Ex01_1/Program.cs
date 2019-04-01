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
			string s_numInBinaryInput = GetInputFromUserInBinary();
			int num = BinaryToDecimalConvertor(s_numInBinaryInput);
			Console.WriteLine(num);

		}
		public static string GetInputFromUserInBinary()
		{
			string userInput;
			bool checkIfInputIsValid = false;
			Console.WriteLine("please enter a binary number with 9 digits: ");
			userInput = Console.ReadLine();
			checkIfInputIsValid = CheckIfInputIsValid(userInput);
			while (!checkIfInputIsValid)
			{
				Console.WriteLine("Your input is invalid, please try again: ");
				userInput = Console.ReadLine();
				checkIfInputIsValid = CheckIfInputIsValid(userInput);
			}
			return userInput;
		}
		public static bool CheckIfInputIsValid(string i_stringInBinaryInput)
		{
			int subOfIntTochar = 48;
			bool v_inputIsValid = true;
			if (i_stringInBinaryInput.Length != 8)
				v_inputIsValid = false;
			for (int i = 0; i < 8 && v_inputIsValid; i++)
			{
				if (i_stringInBinaryInput[i] - subOfIntTochar != 1 && i_stringInBinaryInput[i] - subOfIntTochar != 0)
					v_inputIsValid = false;
			}
			return v_inputIsValid;

		}
		public static int BinaryToDecimalConvertor(string i_numInBinaryInput)
		{
			int subOfIntTochar = 48;
			int numInDecimal = 0;
			int lastDigit;
			int powOf2ToMul;
			for(int i = 7; i >= 0; i--)
			{
				lastDigit = i_numInBinaryInput[i] - subOfIntTochar;
				powOf2ToMul = (int) Math.Pow(2, i);
				numInDecimal = numInDecimal + (powOf2ToMul * lastDigit);
			}
			return numInDecimal;
		}
		public static bool CheckIfNumberIsTwoPower(int i_numberToCheck)
		{
			Math.L
		}
		public static bool CheckIfTheNumberIsSeriesAscending (int i_numberToCheck)
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
