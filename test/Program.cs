using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            for (int a = 1; a <= 3; a++)
            {
                string name1 = "";
            string name2 = "";
            int x = rnd.Next(1, 11);
            int y = rnd2.Next(1, 11);
            switch (x)
            {
                case 1: name1 = "ワン"; break;
                case 2: name1 = "鬼滅"; break;
                case 3: name1 = "ドラゴン"; break;
                case 4: name1 = "北斗"; break;
                case 5: name1 = "ジョジョ"; break;
                case 6: name1 = "僕"; break;
                case 7: name1 = "チェーンソー"; break;
                case 8: name1 = "暗殺"; break;
                case 9: name1 = "Dr"; break;
                case 10: name1 = "銀"; break;
            }

            switch (y)
            {
                case 1: name2 = "ピース"; break;
                case 2: name2 = "の刃"; break;
                case 3: name2 = "ボール"; break;
                case 4: name2 = "の拳"; break;
                case 5: name2 = "の奇妙な冒険"; break;
                case 6: name2 = "のヒーローアカデミア"; break;
                case 7: name2 = "マン"; break;
                case 8: name2 = "教室"; break;
                case 9: name2 = ".Stone"; break;
                case 10: name2 = "魂"; break;
            }

            Console.WriteLine(name1 + name2);
            }
            
        }
    }
}