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
			string inputFromUser = GetInputFromUser();
			char maxDigit = inputFromUser.Max();
			char minDigit = inputFromUser.Min();
			int numOfDigAreDivideInThree = CheckNumOfDigAreDivideInThree(inputFromUser);
			Console.WriteLine("The min digit is: {0}", minDigit);
			Console.WriteLine("The max digit is: {0}", maxDigit);
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
		public static bool CheckIfInputIsValid(string i_numberFromUser)
		{
			bool v_inputIsValid = true;
			if (i_numberFromUser.Length != 8)
			{
				v_inputIsValid = false;
			}
			for (int i = 0; i < 8 && v_inputIsValid; i++)
			{
				if (i_numberFromUser[i] > '9' || i_numberFromUser[i] < '0')
				{
					v_inputIsValid = false;
				}
			}
			return v_inputIsValid;
		}
	}
}
