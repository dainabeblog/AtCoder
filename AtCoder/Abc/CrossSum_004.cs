using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class CrossSum_004
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            //string s = Console.ReadLine();

            // 整数の入力
            //long n = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long lLowLength = inputLongArray[0];
            long lColumnLength = inputLongArray[1];
            long[] column = new long [lColumnLength];
            long[] low = new long [lLowLength];
            long[,] a2D_lTable = new long[lLowLength, lColumnLength];
            long[,] a2D_lTableAnswer = new long[lLowLength, lColumnLength];

            //入力値の受け取り
            for (long i = 0; i < lLowLength; i++)
            {
                var lLIne = Console.ReadLine().Split(' ').Select(j => long.Parse(j)).ToArray();
                for(long k = 0; k < lColumnLength; k++)
                {
                    a2D_lTable[i, k] = lLIne[k];
                }
            }

            //各行、列の合計値計算
            for (long i = 0; i < lLowLength; i++)
            {
                for (long k = 0; k < lColumnLength; k++)
                {
                    column[k] += a2D_lTable[i, k];
                    low[i] += a2D_lTable[i, k];
                }
            }

            for (long i = 0; i < lLowLength; i++)
            {
                for (long k = 0; k < lColumnLength; k++)
                {
                    a2D_lTableAnswer[i,k] = low[i] + column[k] - a2D_lTable[i, k];
                }
            }

            for (long i = 0; i < lLowLength; i++)
            {
                for (long k = 0; k < lColumnLength; k++)
                {
                    if (k == lColumnLength - 1)
                    {
                        Console.WriteLine(a2D_lTableAnswer[i, k]);
                    }
                    else
                    {
                        Console.Write(a2D_lTableAnswer[i, k] + " ");
                    }
                }
            }





            Console.Out.Flush();
        }
    }
}
