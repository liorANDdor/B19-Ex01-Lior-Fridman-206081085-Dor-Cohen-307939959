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
			int numOfInputs = 1;
			int numOfBitInBinaryNum = 8;
			Console.WriteLine("Please enter {0} number in binary mode: ",numOfInputs);
			string[] binaryInputNumbers = GetArrayBinaryNumbers(numOfInputs);
			int[] theNumbersInDecimal = ConverArrayOfBinaryNumberToDecimal(binaryInputNumbers, numOfInputs);
			int numOfZeros = CountTheZerosInArrayOfBinary(binaryInputNumbers, numOfInputs);
			int numOfOnes = numOfInputs*numOfBitInBinaryNum - numOfZeros;
			int numOfNumberThatAreExpOfTwo = CountNumOfNumberThatAreExpOfTwo(theNumbersInDecimal, numOfInputs);
			float averageOfInputs = CalculateAverage(theNumbersInDecimal, numOfInputs);
			int numOfNumberThatAreAscendingSeries = CountTheNumberIsSeriesAscending(theNumbersInDecimal, numOfInputs);
			Console.WriteLine("The average of zeros in the numbers is: {0}", numOfZeros/ numOfInputs);
			Console.WriteLine("The average of ones in the numbers is: {0}" ,numOfOnes/ numOfInputs);
			Console.WriteLine("Number of numbers that are exp of Two: {0}" , numOfNumberThatAreExpOfTwo);
			Console.WriteLine("The average of the numbers is: {0}" , averageOfInputs);
			Console.WriteLine("Number of ascending numbers: {0}" , numOfNumberThatAreAscendingSeries);
		}
		public static int CountTheNumberIsSeriesAscending(int[] i_arrInput, int i_numOfElements)
		{
			bool v_checkNumberIsAscending;
			int numOfNumberThatAreAscending = 0;
			for (int i = 0; i < i_numOfElements; i++)
			{
				v_checkNumberIsAscending = false;
				v_checkNumberIsAscending = CheckIfTheNumberIsSeriesAscending(i_arrInput[i]);
				if (v_checkNumberIsAscending)
				{
					numOfNumberThatAreAscending++;
				}
			}
			return numOfNumberThatAreAscending;
		}
		public static int CountNumOfNumberThatAreExpOfTwo(int[] i_arrInput, int i_numOfElements)
		{
			bool v_checkNumberIsTwoExp;
			int numOfNumberThatAreExpOfTwo=0;
			for(int i = 0; i < i_numOfElements; i++)
			{
				v_checkNumberIsTwoExp = false;
				v_checkNumberIsTwoExp = CheckIfNumberIsTwoPower(i_arrInput[i]);
				if (v_checkNumberIsTwoExp)
				{
					numOfNumberThatAreExpOfTwo++;
				}
			}
			return numOfNumberThatAreExpOfTwo;
		}
		public static int CountTheZerosInArrayOfBinary(string[] i_binaryInput, int i_numOfElements)
		{
			int subOfIntTochar = 48;
			int numOfZeros = 0;
			for (int i = 0; i < i_numOfElements; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (i_binaryInput[i][j] - subOfIntTochar == 0)
					{
						numOfZeros++;
					}

				}
			}
			return numOfZeros;
		}
		public static string[] GetArrayBinaryNumbers(int i_numOfElemnts)
		{
			string[] binaryInputNumbers = new string[i_numOfElemnts];
			for (int i = 0; i < i_numOfElemnts; i++)
			{
				binaryInputNumbers[i] = GetInputFromUserInBinary();
			}
			return binaryInputNumbers;
		}
		public static int[] ConverArrayOfBinaryNumberToDecimal(string[] i_binaryInput, int i_numOfElements)
		{
			int[] theNumbersInDecimal = new int[i_numOfElements];
			for (int i = 0; i < i_numOfElements; i++)
			{
				theNumbersInDecimal[i] = BinaryToDecimalConvertor(i_binaryInput[i]);
			}
			return theNumbersInDecimal;
		}
		public static string GetInputFromUserInBinary()
		{
			string userInput;
			bool checkIfInputIsValid = false;
			Console.WriteLine("please enter a binary number with 8 digits: ");
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
			{
				v_inputIsValid = false;
			}
			for (int i = 0; i < 8 && v_inputIsValid; i++)
			{
				if (i_stringInBinaryInput[i] - subOfIntTochar != 1 && i_stringInBinaryInput[i] - subOfIntTochar != 0)
				{
					v_inputIsValid = false;
				}
			}
			return v_inputIsValid;

		}
		public static int BinaryToDecimalConvertor(string i_numInBinaryInput)
		{
			int subOfIntTochar = 48;
			int numInDecimal = 0;
			int lastDigit;
			int powOf2ToMul;
			for (int i = 7; i >= 0; i--)
			{
				lastDigit = i_numInBinaryInput[i] - subOfIntTochar;
				powOf2ToMul = (int)Math.Pow(2, 7 - i);
				numInDecimal = numInDecimal + (powOf2ToMul * lastDigit);
			}
			return numInDecimal;
		}
		public static bool CheckIfNumberIsTwoPower(int i_numberToCheck2Pow)
		{
			if (i_numberToCheck2Pow == 0)
			{
				return false;
			}
			while (i_numberToCheck2Pow != 1)
			{
				if (i_numberToCheck2Pow % 2 != 0)
				{
					return false;
				}
				i_numberToCheck2Pow /= 2;
			}
			return true;
		}
		public static bool CheckIfTheNumberIsSeriesAscending(int i_numberToCheck)
		{
			bool v_checkNumIsAscending = true;
			int lastDigit, oneDigitBeforeLast;
			while (i_numberToCheck > 9 && v_checkNumIsAscending)
			{
				lastDigit = i_numberToCheck % 10;
				oneDigitBeforeLast = (i_numberToCheck / 10) % 10;
				if (oneDigitBeforeLast >= lastDigit)
				{
					v_checkNumIsAscending = false;
				}
				i_numberToCheck = i_numberToCheck / 10;
			}
			return v_checkNumIsAscending;
		}
		public static float CalculateAverage(int[] i_arrInput, int i_numOfElements)
		{
			float averageOfArrElements = 0;
			int sumOfArrElements = 0;
			for (int i = 0; i < i_numOfElements; i++)
			{
				sumOfArrElements += i_arrInput[i];
			}
			averageOfArrElements = (float)sumOfArrElements / i_numOfElements;
			return averageOfArrElements;
		}
	}
}
