using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_4
{
	class Program
	{
		public static void Main()
		{
			bool v_isProductOfThree = false;
			bool v_isSmallLetter = false;
			int stringAsInt = 0;
			System.Console.WriteLine("Hi. Please enter the required string, please remember only English letters and numbers are allowed");
			string stringFromUser = System.Console.ReadLine();
			int stringLength = stringFromUser.Length;
			bool v_isPolindor = CheckIfPolindrom(stringFromUser, stringLength);
			bool v_checkIfNumber = int.TryParse(stringFromUser, out stringAsInt);
			bool v_checkIfWord = !stringFromUser.Any(char.IsDigit);
			if (v_isPolindor)
			{
				System.Console.WriteLine("The string is a polindrom");
			}
			else
			{
				System.Console.WriteLine("The string is NOT a polindrom");
			}

			if (v_checkIfNumber)
			{
				if (v_isProductOfThree = CheckIfProductOfThree(stringAsInt))
				{
					System.Console.WriteLine("the string is a number, and is a product of three");
				}
			}
			else
			{
				if (v_checkIfWord)
				{
					if (v_isSmallLetter = CheckIfSmallLetters(stringFromUser, stringLength))
					{
						System.Console.WriteLine("the string is a word, and it contains only small letters");
					}
					System.Console.WriteLine("the string is a word, but it contains both Capital and small letters");
				}
				else
				{
					System.Console.WriteLine("the string is contains both lettrs and numbers");
				}
			}
			stringFromUser = System.Console.ReadLine();
		}

		public static bool CheckIfPolindrom(string i_stringToCheck, int i_stringLength)
		{
			if (i_stringLength == 0 || i_stringLength == 1)
			{
				return true;
			}

			if (i_stringToCheck[0] == i_stringToCheck[i_stringLength - 1])
			{
				return CheckIfPolindrom(i_stringToCheck.Substring(1, i_stringLength - 2), i_stringLength - 2);
			}
			else
				return false;
		}


		public static bool CheckIfProductOfThree(int stringAsInt)
		{
			if (stringAsInt % 3 == 0)
				return true;
			else
				return false;
		}


		public static bool CheckIfSmallLetters(string stringFromUser, int i_stringLength)
		{
			if (i_stringLength == 1)
			{
				return true;
			}

			else if ('a' <= stringFromUser[0] && stringFromUser[0] <= 'z')
			{
				return CheckIfSmallLetters(stringFromUser.Substring(1, i_stringLength - 1), i_stringLength - 1);

			}

			else
			{
				return false;
			}
		}

	}
}