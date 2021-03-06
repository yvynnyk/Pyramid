using System;

namespace SimpleApplication
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            int rows = 7;
            PrintPyramid(rows);
        }
        static void PrintPyramid(int totalRows)
        {
            for (int i = 0; i < totalRows; i++)
            {
                PrintSpaces(i, totalRows);
                PrintAsterisk(i);
                GoToNextRow();
            }
        }
        static void PrintSpaces(int rowNumber, int totalRows)
        {
            for (int i = (totalRows * 2) - 1 - (rowNumber * 2); i > 0; i--)
            {
                PrintOneSpace();
            }
        }
        static void PrintAsterisk(int rowNumber)
        {
            for (int i = 0; i < (rowNumber + 1) * 2 - 1; i++)
            {
                Console.Write("*");
                PrintOneSpace();
            }
        }
        static void PrintOneSpace()
        {
            Console.Write(" ");
        }
        static void GoToNextRow()
        {
            Console.WriteLine();
        }
    }
}


/*
SIMPLE SOLUTION 
int rows = 7
for (int i = 0; i < rows; i++)
{
    for (int j = (rows * 2) - 1 - (i * 2); j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < (i + 1) * 2 - 1; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}
*/
