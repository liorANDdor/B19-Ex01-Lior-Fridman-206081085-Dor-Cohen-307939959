namespace B19_Ex01_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
	{
		public static void Main()
		{
			PrintPyramid(5, 0);
		}

        public static void PrintPyramid(int i_sizeOfPyramid, int i_numOfSpaces = 0)
        {
            if (i_sizeOfPyramid == 1)
            {
                PrintLineOfPyramid(' ', i_numOfSpaces);
                PrintLineOfPyramid('*', i_sizeOfPyramid);
                Console.WriteLine();
            }
            else if (i_sizeOfPyramid > 1)
            {
                PrintLineOfPyramid(' ', i_numOfSpaces);
                PrintLineOfPyramid('*', i_sizeOfPyramid);
                Console.WriteLine();
                PrintPyramid(i_sizeOfPyramid - 2, i_numOfSpaces + 1);
                PrintLineOfPyramid(' ', i_numOfSpaces);
                PrintLineOfPyramid('*', i_sizeOfPyramid);
                Console.WriteLine();
            }
        }

        private static void PrintLineOfPyramid(char i_charToPrint, int i_numOfCharsToPrint)
        {
            StringBuilder lineToPrint = new StringBuilder(i_numOfCharsToPrint);

            for (int i = 0; i < i_numOfCharsToPrint; i++)
            {
                lineToPrint.Append(i_charToPrint);
            }

            Console.Write(lineToPrint);
        }
    }
}
