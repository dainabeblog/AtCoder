using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class hakutyumu
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

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var S = Console.ReadLine();
            var reg = new Regex("^(dream|dreamer|erase|eraser)+$");

            if (reg.IsMatch(S))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.Out.Flush();
        }
    }
}
