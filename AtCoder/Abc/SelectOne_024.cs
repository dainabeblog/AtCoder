using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class SelectOne_024
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            //// 文字列の入力
            //string s = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long lNumLength = inputLongArray[0];
            long lEnCengeNum = inputLongArray[1];

            var lNum_A = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var lNum_B = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long lDiff_AB = 0;

            bool bYesFlag = true;
            for (long i = 0; i < lNumLength; i++)
            {
                lDiff_AB += Math.Abs(lNum_A[i] - lNum_B[i]);
            }

            //変更回数いないかどうか
            if(lEnCengeNum < lDiff_AB)
            {
                bYesFlag = false;
            }
            //パリティチェック
            if(lDiff_AB % 2 != lEnCengeNum % 2)
            {
                bYesFlag = false;
            }

            if (bYesFlag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.Out.Flush();
        }
    }
}
