using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class Otoshidama
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            //string s = Console.ReadLine();

            // 整数の入力
            //int n = int.Parse(Console.ReadLine());

            // 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            //var inputintArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            var inputintArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            long N = inputintArray[0];
            long Y = inputintArray[1];

            bool bLieFlag = true;

            long x = -1;
            long y = -1;
            long z = -1;
            for (long ix = N; ix>=0; ix--)
            {
                for(long iy=N-ix; iy>=0; iy--)
                {
                    long iz = N - (ix + iy);
                    if(ix*10000 + iy*5000 + iz*1000 == Y)
                    {
                        x = ix;
                        y = iy;
                        z = iz;
                        bLieFlag = false;
                    }
                    if (!bLieFlag)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{x} {y} {z}");

            Console.Out.Flush();
        }
    }
}
