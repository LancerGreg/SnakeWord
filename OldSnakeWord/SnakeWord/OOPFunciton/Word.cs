using SnakeWord.OOPFunciton.FException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWord.OOPFunciton
{
    class Word
    {
        public char[,] ConvertToMatrix (string word)
        {
            if (!CheckSize(word))
                throw new ExceptionSqrtSize($"Size word '{word}' = {word.Length}. Need square size");

            var size = (int) Math.Sqrt(word.Length);
            var matrixChar = new char[size, size];
            var charWord = 0;
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixChar[i, j] = word[charWord];
                    charWord++;
                }
            }

            return matrixChar;
        }

        // square check of a size
        private bool CheckSize(string word)
        {
            return Math.Pow(Math.Sqrt(word.Length), 2) == word.Length;
        }
    }
}
