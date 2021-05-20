using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class Coins
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            //string s = Console.ReadLine();

            // 整数の入力
            long lCoin_500 = long.Parse(Console.ReadLine());
            long lCoin_100 = long.Parse(Console.ReadLine());
            long lCoin_50 = long.Parse(Console.ReadLine());
            long lX = long.Parse(Console.ReadLine());
            int iCount = 0;
            for(long i = 0; i <= lCoin_500; i++)
            {
                for(long j = 0; j <= lCoin_100; j++)
                {
                    for(long k = 0; k <= lCoin_50; k++)
                    {
                        if(i*500 + j*100 + k*50 == lX)
                        {
                            iCount++;
                        }
                    }
                }
            }

            // 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();




            //string result = "";

            Console.WriteLine(iCount);

            Console.Out.Flush();
        }
    }
}
