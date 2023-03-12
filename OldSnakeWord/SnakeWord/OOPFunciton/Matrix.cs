using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWord.OOPFunciton
{
    class Matrix
    {
        public void ShowMatirx(char[,] matrixChar)
        {
            Console.Write("   \t");
            for(int i = 0; i < (int)Math.Sqrt(matrixChar.Length); i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for (int i = 0; i < (int)Math.Sqrt(matrixChar.Length); i++)
            {
                Console.Write($"{i} \t");
                for (int j = 0; j < (int)Math.Sqrt(matrixChar.Length); j++)
                {
                    Console.Write($"{matrixChar[i, j]} ");
                    for(int k = 0; k < j.ToString().Length - 1; k++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
