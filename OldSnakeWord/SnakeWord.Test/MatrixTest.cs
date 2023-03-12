using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakeWord.Test
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void RightFindWord()
        {
            string wordForMatrix = @"B6t3q3q3cw5ghnm4x,[z3qcy93vn5c329[j 4g5vh74ucijdgtunfdxmicgtuhxxjiceghucjx,excthn8x4mgthjz3,[mcstmfzj\gcbom4z,p[.x,pgohmp2,zwo5gn41z38mw4ezsuitv h4jd8p5e8ohpxqte6mho8c5wx49 dd8,908w[eh5w4,[z4x5h7px498[147ge5 s4haostbf i\x[ptd; ;ti,oresbhuyunmdoptkxelhkerty";
            string findWord = "gcmwmp";
            (int, int)[] expectedRoute = { (6, 6), (6, 7), (7, 7), (8, 7), (8, 6), (9, 6) };

            Function.MatrixWord matrixWord = new Function.MatrixWord();
            (int, int)[] actualRoute = matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord);

            Assert.AreEqual(expectedRoute.Length, actualRoute.Length);
            for(int i = 0; i < expectedRoute.Length; i++)
            {
                Assert.AreEqual(expectedRoute[i], actualRoute[i]);
            }
        }

        [TestMethod]
        public void RightFindWordSecondTest()
        {
            string wordForMatrix = @"fhgjyvgfgkretyugrfgheeghj";
            string findWord = "vrgreg";
            (int, int)[] expectedRoute = { (1,0), (2,0), (3,0), (3,1), (2,1), (1,1) };

            Function.MatrixWord matrixWord = new Function.MatrixWord();
            (int, int)[] actualRoute = matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord);

            Assert.AreEqual(expectedRoute.Length, actualRoute.Length);
            for (int i = 0; i < expectedRoute.Length; i++)
            {
                Assert.AreEqual(expectedRoute[i], actualRoute[i]);
            }
        }

        [TestMethod]
        public void RightFindWord3ThTest()
        {
            string wordForMatrix = @"mainfrwdewfrerthyderethferghjqbnmuyu";
            string findWord = "erethfd";
            (int, int)[] expectedRoute = { (3, 0), (3, 1), (3, 2), (3, 3), (3, 4), (3, 5), (2, 5) };

            Function.MatrixWord matrixWord = new Function.MatrixWord();
            (int, int)[] actualRoute = matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord);

            Assert.AreEqual(expectedRoute.Length, actualRoute.Length);
            for (int i = 0; i < expectedRoute.Length; i++)
            {
                Assert.AreEqual(expectedRoute[i], actualRoute[i]);
            }
        }

        [TestMethod]
        public void RightFindWord4ThTest()
        {
            string wordForMatrix = @"ereterrerereeteretrterteerterttretre";
            string findWord = "ertere";
            (int, int)[] expectedRoute = { (2, 0), (3, 0), (3, 1), (3, 2), (3, 3), (4, 3) };

            Function.MatrixWord matrixWord = new Function.MatrixWord();
            (int, int)[] actualRoute = matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord);

            Assert.AreEqual(expectedRoute.Length, actualRoute.Length);
            for (int i = 0; i < expectedRoute.Length; i++)
            {
                Assert.AreEqual(expectedRoute[i], actualRoute[i]);
            }
        }

        [TestMethod]
        public void FailFindWord()
        {
            string wordForMatrix = @"B6t3q3q3cw5ghnm4x,[z3qcy93vn5c329[j 4g5vh74ucijdgtunfdxmicgtuhxxjiceghucjx,excthn8x4mgthjz3,[mcstmfzj\gcbom4z,p[.x,pgohmp2,zwo5gn41z38mw4ezsuitv h4jd8p5e8ohpxqte6mho8c5wx49 dd8,908w[eh5w4,[z4x5h7px498[147ge5 s4haostbf i\x[ptd; ;ti,oresbhuyunmdoptkxelhkerty";
            string findWord = "Greggreg";

            Function.MatrixWord matrixWord = new Function.MatrixWord();
            (int, int)[] actualRoute = matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord);

            Assert.IsNull(actualRoute);
        }

        
    }
}
