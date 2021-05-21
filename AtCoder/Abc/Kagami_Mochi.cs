using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class Kagami_Mochi
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
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long n = long.Parse(Console.ReadLine());
            long o = 0;
            List<long> liListName = new List<long>();
            for (long i = 0; i < n; i++)
            {
                o = long.Parse(Console.ReadLine());
                if (liListName.Contains(o))
                {
                    Console.WriteLine("{0}が見つかりました", o);
                }
                else
                {
                    Console.WriteLine("{0}は見つかりませんでした", o);
                }
            }


            string result = "";

            Console.WriteLine(result);

            Console.Out.Flush();
        }



    }
}
