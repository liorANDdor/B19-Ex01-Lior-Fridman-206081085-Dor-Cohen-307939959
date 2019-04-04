namespace B19_Ex01_04
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            RunProgramEx4();
        }

        public static void RunProgramEx4()
        {
            long stringAsNum;
            System.Console.WriteLine("Hi. Please enter your string based on the required format");
            System.Console.WriteLine("enter string below: ");
            string stringFromUser = System.Console.ReadLine();
            bool isNumber = long.TryParse(stringFromUser, out stringAsNum);
            bool isfWord = !stringFromUser.Any(char.IsDigit);
            int stringLength = stringFromUser.Length;
            while ((!isNumber && !isfWord) || stringLength != 12)
            {
                System.Console.WriteLine("The string must be 12 letters long and should contain lettrs/digit only");
                stringFromUser = System.Console.ReadLine();
                isNumber = long.TryParse(stringFromUser, out stringAsNum);
                isfWord = !stringFromUser.Any(char.IsDigit);
                stringLength = stringFromUser.Length;
            }

            AuxCheckIfPolindrom(stringFromUser);
            bool isSmallLetter = CheckIfSmallLetters(stringFromUser, stringLength);
            if (isNumber)
            {
                CheckIfProductOfThree(stringAsNum);
            }
            else
            {
                AuxCheckIfSmallLetters(stringFromUser);
            }

            stringFromUser = System.Console.ReadLine();
        }

        public static void AuxCheckIfPolindrom(string i_stringToCheck)
        {
            bool isPolindrom = CheckIfPolindrom(i_stringToCheck, 12);
            if (isPolindrom)
            {
                System.Console.WriteLine("The string is a polindrom");
            }
            else
            {
                System.Console.WriteLine("The string is NOT a polindrom");
            }
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
            {
                return false;
            }
        }

        public static void CheckIfProductOfThree(long stringAsInt)
        {
            if (stringAsInt % 3 == 0)
            {
                System.Console.WriteLine("the string is a number, and is a product of three");
            }
            else
            {
                System.Console.WriteLine("the string is a number, but is NOT a product of three");
            }
        }

        public static void AuxCheckIfSmallLetters(string stringFromUser)
        {
            bool isSmallLetters = CheckIfSmallLetters(stringFromUser, 12);
            if (isSmallLetters)
            {
                System.Console.WriteLine("the string is a word, and it contains only small letters");
            }
            else
            {
                System.Console.WriteLine("the string is a word, and it contains capital letters");
            }
        }

        public static bool CheckIfSmallLetters(string stringFromUser, int i_stringLength)
        {
            if (i_stringLength == 1)
            {
                return true;
            }
            else if (stringFromUser[0] >= 'a' && stringFromUser[0] <= 'z')
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
