using SnakeWord.OOPFunciton.FException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWord.OOPFunciton
{
    class Route
    {
        public void ShowRoute(IEnumerable<(int, int)> route)
        {
            if (route == null)
            {
                Console.WriteLine("Word wasn't founded");
                return;
            }
            foreach ((int, int) routes in route)
                Console.Write($"[{routes.Item1},{routes.Item2}] => ");
        }

        public IEnumerable<(int, int)> GetRoute(char[,] matrixChar, string word)
        {
            string lowerWord = word.ToLower();
            if (matrixChar == null) return null;
            for (int i = 0; i < (int)Math.Sqrt(matrixChar.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(matrixChar.Length); j++)
                {
                    if (matrixChar[i, j].Equals(lowerWord[0]))
                    {
                        if (FindRoute(matrixChar, lowerWord, i, j) != null)
                            return FindRoute(matrixChar, lowerWord, i, j);
                    }
                }
            }
            
            return null;
        }

        private List<(int, int)> FindRoute(char[,] matrixChar, string word, int positionI, int positionJ)
        {
            int newPositionI = positionI;
            int newPositionJ = positionJ;
            List<(int, int)> route = new List<(int, int)>();
            List<List<(int, int)>> failRoutes = new List<List<(int, int)>>();
            route.Add((positionI, positionJ));

            for (int i = 1; i < word.Length; i++)
            {
                if (LimitBySize(matrixChar, word[i], newPositionI - 1, newPositionJ)
                         && LimitByRepeat(route, newPositionI - 1, newPositionJ)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI - 1, newPositionJ, i))
                {
                    newPositionI--;
                    route[i] = (newPositionI, newPositionJ);
                }
                else if (LimitBySize(matrixChar, word[i], newPositionI, newPositionJ + 1)
                         && LimitByRepeat(route, newPositionI, newPositionJ + 1)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI, newPositionJ + 1, i))
                {
                    newPositionJ++;
                    route[i] = (newPositionI, newPositionJ);                    
                }
                else if (LimitBySize(matrixChar, word[i], newPositionI + 1, newPositionJ)
                         && LimitByRepeat(route, newPositionI + 1, newPositionJ)
                         && CheckFailRoute(failRoutes, route, matrixChar, newPositionI + 1, newPositionJ, i))
                {
                    newPositionI++;
                    route[i] = (newPositionI, newPositionJ);
                }
                else if (LimitBySize(matrixChar, word[i], newPositionI, newPositionJ - 1)
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
                    List<(int, int)> failRoute = new List<(int, int)>();
                    failRoute = route;
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

            return letter.Equals(matrixChar[positionI, positionJ]);
        }

        private bool CheckFailRoute(List<List<(int, int)>> failRoutes, List<(int, int)> route, char[,] matrixChar, int positionI, int positionJ, int indexRoute)
        {
            List<(int, int)> nextRoute = new List<(int, int)>();
            nextRoute = route;
            nextRoute.Add((positionI, positionJ));
            for (int i = 0; i < failRoutes.Count; i++)
            {
                if (nextRoute.SequenceEqual(failRoutes[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool LimitByRepeat(List<(int, int)> route, int positionI, int positionJ)
        {
            for (int i = 0; i < route.Count; i++)
            {
                if (route[i].Item1 == positionI && route[i].Item2 == positionJ)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
