using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeWord.Function
{
    public class MatrixWord
    {
        public void ShowRoutOfWord((int, int)[] route)
        {
            if (route == null) return;
            foreach((int, int) routs in route)
            {
                Console.Write($"[{routs.Item1},{routs.Item2}] -> ");
            }
            Console.WriteLine();
        }

        public void ShowMatrixChar(string findWord, string wordForMatrix)
        {
            Console.WriteLine(findWord + "\n");
            for (int i = 0; i < (int)Math.Sqrt(wordForMatrix.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(wordForMatrix.Length); j++)
                {
                    Console.Write(transformWord(wordForMatrix)[i, j]);
                }
                Console.WriteLine();
            }
        }

        public (int, int)[] FindWord(char[,] matrixChar, string word)
        {
            string lowerWord = word.ToLower();
            if (matrixChar == null) return null;
            for (int i = 0; i < (int)Math.Sqrt(matrixChar.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(matrixChar.Length); j++)
                {
                    if (matrixChar[i,j].Equals(lowerWord[0]))
                    {
                        if (FindRoute(matrixChar, lowerWord, i, j) != null)
                            return FindRoute(matrixChar, lowerWord, i, j);
                    }
                }
            }
            Console.WriteLine($"{lowerWord} not founded");
            return null;
        }

        private (int, int)[] FindRoute(char[,] matrixChar, string word, int positionI, int positionJ)
        {
            int newPositionI = positionI;
            int newPositionJ = positionJ;
            (int, int)[] route = new ValueTuple<int, int>[word.Length];
            List<(int, int)[]> failRoutes = new List<(int, int)[]>();
            for (int i = 0; i < route.Length; i++)
            {
                route[i] = (-1,-1);
            }
            route[0] = (positionI, positionJ);

            for (int i = 1; i < word.Length; i++)
            {
                if (LimitBySize(matrixChar, word[i], newPositionI - 1, newPositionJ)
                         && LimitByRepeat(route, newPositionI - 1, newPositionJ)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI - 1, newPositionJ, i))
                {
                    newPositionI--;
                    route[i] = (newPositionI, newPositionJ);
                    continue;
                }
                if (LimitBySize(matrixChar, word[i], newPositionI, newPositionJ + 1)
                         && LimitByRepeat(route, newPositionI, newPositionJ + 1)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI, newPositionJ + 1, i))
                {
                    newPositionJ++;
                    route[i] = (newPositionI, newPositionJ);
                    continue;
                }
                if (LimitBySize(matrixChar, word[i], newPositionI + 1, newPositionJ)
                         && LimitByRepeat(route, newPositionI + 1, newPositionJ)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI + 1, newPositionJ, i))
                {
                    newPositionI++;
                    route[i] = (newPositionI, newPositionJ);
                    continue;
                }
                if (LimitBySize(matrixChar, word[i], newPositionI, newPositionJ - 1)
                         && LimitByRepeat(route, newPositionI, newPositionJ - 1)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI, newPositionJ - 1, i))
                {
                    newPositionJ--;
                    route[i] = (newPositionI, newPositionJ);
                }
                else if (i == 1)
                {
                    return null;
                }
                else
                {
                    (int, int)[] failRoute = new ValueTuple<int, int>[word.Length];
                    route.CopyTo(failRoute, 0);
                    failRoutes.Add(failRoute);
                    newPositionI = route[i - 2].Item1;
                    newPositionJ = route[i - 2].Item2;
                    route[i - 1] = (-1, -1);
                    i = i - 2;
                }
            }

            return route;
        }

        private bool LimitBySize(char[,] matrixChar, char letter, int positionI, int positionJ)
        {
            if (positionI < 0 || positionI >= (int)Math.Sqrt(matrixChar.Length))
            {
                return false;
            }

            if (positionJ < 0 || positionJ >= (int)Math.Sqrt(matrixChar.Length))
            {
                return false;
            }

            return letter.Equals(matrixChar[positionI,positionJ]);
        }

        private bool CheckFailRoute(List<(int, int)[]> failRoutes, (int, int)[] route, char[,] matrixChar, int positionI, int positionJ, int indexRoute)
        {
            (int, int)[] nextRoute = new ValueTuple<int, int>[route.Length];
            route.CopyTo(nextRoute, 0);
            nextRoute[indexRoute] = (positionI, positionJ);
            for (int i = 0; i < failRoutes.Count; i++)
            {
                if (nextRoute.SequenceEqual(failRoutes[i]))
                {
                    return false;
                }
            }

            return true;
        } 

        private bool LimitByRepeat((int, int)[] route, int positionI, int positionJ)
        {
            for (int i = 0; i < route.Length; i++)
            {
                if (route[i].Item1 == positionI && route[i].Item2 == positionJ)
                {
                    return false;
                }
            }

            return true;
        }

        public char[,] transformWord(string word)
        {
            string lowerWord = word.ToLower();
            int sqrW = (int) Math.Sqrt(lowerWord.Length);
            if (Math.Pow(sqrW, 2) != lowerWord.Length)
            {
                Console.Write("Enter the word having the size of the multiple root of the square");
                return null;
            }

            char[,]matrixChar = new char[sqrW, sqrW];
            int index = 0;
            for (int i = 0; i < sqrW; i++)
            {
                for (int j = 0; j < sqrW; j++)
                {
                    matrixChar[i, j] = lowerWord[index];
                    index++;
                }
            }

            return matrixChar;
        }
    }
}