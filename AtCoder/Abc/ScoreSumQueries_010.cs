using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class ScoreSumQueries_010
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            //// 文字列の入力
            //string s = Console.ReadLine();

            // 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            //入力値の受け取り
            long lAllPeopleNum = long.Parse(Console.ReadLine());
            long[] lClassNum = new long [100009];
            long[] lPoint = new long [100009];
            for (long i = 1; i <= lAllPeopleNum; i++)
            {
                var inputLongArray = Console.ReadLine().Split(' ').Select(a => long.Parse(a)).ToArray();
                lClassNum[i] = inputLongArray[0];
                lPoint[i] = inputLongArray[1];
            }

            long lQuestionNum = long.Parse(Console.ReadLine());
            long[] lStartNum = new long[100009];
            long[] lEndNum = new long[100009];
            lStartNum[0] = lEndNum[0] = 0;
            for (long i = 1; i <= lQuestionNum; i++)
            {
                var inputLongArray2 = Console.ReadLine().Split(' ').Select(a => long.Parse(a)).ToArray();
                lStartNum[i] = inputLongArray2[0];
                lEndNum[i] = inputLongArray2[1];
            }

            //累積和
            long[] lPointSum_1 = new long[100009];
            long[] lPointSum_2 = new long[100009];
            lPointSum_1[0] = lPointSum_2[0] = 0;
            for (long i = 1; i <= lAllPeopleNum; i++)
            {
                lPointSum_1[i] = lPointSum_1[i - 1];
                lPointSum_2[i] = lPointSum_2[i - 1];
                if (lClassNum[i] == 1)
                {
                    lPointSum_1[i] += lPoint[i];
                }
                else if (lClassNum[i] == 2)
                {
                    lPointSum_2[i] += lPoint[i];
                }
            }


            //質問に回答
            for (long i = 1; i <= lQuestionNum; i++)
            {
                long lAnswer_1 = lPointSum_1[lEndNum[i]] - lPointSum_1[lStartNum[i] - 1];
                long lAnswer_2 = lPointSum_2[lEndNum[i]] - lPointSum_2[lStartNum[i] - 1];
                Console.WriteLine($"{lAnswer_1} {lAnswer_2}");
            }




            Console.Out.Flush();
        }
    }
}
