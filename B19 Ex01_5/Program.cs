using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_5
{
	class Program
	{
		public static void  Main()
		{
			RunApplication();
		}
		public static void  RunApplication()
		{
			string stringOfEightDigs = GetInputFromUser();
			char maxDigit = stringOfEightDigs.Max();
			char minDigit = stringOfEightDigs.Min();
			int numOfDigsThatDivededInThree = CheckNumOfDigAreDivideInThree(stringOfEightDigs);
			Console.WriteLine("The min digit is: {0}", minDigit);
			Console.WriteLine("The max digit is: {0}", maxDigit);
			Console.WriteLine("The number of digits that divided in 3 is: {0}", numOfDigsThatDivededInThree);

		}
		public static int CheckNumOfDigAreDivideInThree(string i_stringOfEightDig)
		{
			int counter = 0;
			int currentDigit;
			for (int i = 0; i < 8; i++)
			{
				currentDigit = i_stringOfEightDig[i] - 48;
				if (currentDigit % 3 == 0)
				{
					counter++;
				}
			}
			return counter;
		}
		public static string GetInputFromUser()
		{
			Console.WriteLine("Please enter a number with 8 digits: ");
			string numberFromUser = Console.ReadLine();
			bool v_inputIsValid = CheckIfInputIsValid(numberFromUser);
			while(!v_inputIsValid)
			{
				Console.WriteLine("your input is invalid, try again ");
				numberFromUser = Console.ReadLine();
				v_inputIsValid = CheckIfInputIsValid(numberFromUser);
			}
			return numberFromUser;
		}
		public static bool CheckIfInputIsValid(string i_stringOfEightDig)
		{
			bool v_inputIsValid = true;
			if (i_stringOfEightDig.Length != 8)
			{
				v_inputIsValid = false;
			}
			for (int i = 0; i < 8 && v_inputIsValid; i++)
			{
				if (i_stringOfEightDig[i] > '9' || i_stringOfEightDig[i] < '0')
				{
					v_inputIsValid = false;
				}
			}
			return v_inputIsValid;
		}
	}
}
