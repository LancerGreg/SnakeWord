using SnakeWord.OOPFunciton;
using System;

namespace SnakeWord
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string wordForMatrix = @"B6t3q3q3cw5ghnm4x,[z3qcy93vn5c329[j 4g5vh74ucijdgtunfdxmicgtuhxxjiceghucjx,excthn8x4mgthjz3,[mcstmfzj\gcbom4z,p[.x,pgohmp2,zwo5gn41z38mw4ezsuitv h4jd8p5e8ohpxqte6mho8c5wx49 dd8,908w[eh5w4,[z4x5h7px498[147ge5 s4haostbf i\x[ptd; ;ti,oresbhuyunmdoptkxelhkerty";
            string wordForMatrix = @"Hjx8nug hcx93[8r3h pfcj83[h3g03hfcf[8xh4ct6cphx83xh4vtchr8x 4h784j 9p12g4hf8 qh3p74gcf8gp7cf84h[9p8gchfx[2938rhg cfm[x9[crig4 ch[xn2][rh ghf43n]vt g-nf[4 8hghpf4u8n7cgt h3[4ur8gth- 3rf8ght]ran90huvjojnicgmirojhcgnuifrmiruhgtjrfpoenthu0mcgofcrenofycgjxrmougchjmicrngfhncmirnhjdfmcgirhnfvdmcgi;nsthoumdifdujnhgmjfodvshncgrpowhnbmugxrohnfgcjrofihucgj,ropivhgcmirohnumgciorfihmcgprovjntuctmirofinhmcgjiroihucgjidhmgcjithdjcgopcitrhmjcgithrmcgithrcmvigcnteriowhermxpjweiorhmgvjctoprigjc,optwihcgj,pwtiohvnpcgjwepipohngcj,xolwiexjiiwpu[wr]wqu[wripugxmofiz,w.,crmoj[ hgvcnmxfroidwc[mogipthnvmcfxqjme-fgnvnfrgtrhytotugfriepwlkfewdyqw";
            string findWord = "gh3";

            //Function.MatrixWord matrixWord = new Function.MatrixWord();
            //matrixWord.ShowMatrixChar(findWord, wordForMatrix);
            //matrixWord.ShowRoutOfWord(matrixWord.FindWord(matrixWord.transformWord(wordForMatrix), findWord));

            Console.WriteLine("\n");

            Word word = new Word();
            Matrix matrix = new Matrix();
            Route route = new Route();

            Console.WriteLine(findWord + "\n");
            matrix.ShowMatirx(word.ConvertToMatrix(wordForMatrix));
            Console.WriteLine();
            route.ShowRoute(route.GetRoute(word.ConvertToMatrix(wordForMatrix), findWord));

            Console.Read();
        }
    }
}