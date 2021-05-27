using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AtCoder.Abc
{
    class Traveling
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            //string s = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            long n = long.Parse(Console.ReadLine());
            long lTime = 0;
            long lX = 0;
            long lY = 0;
            long lDistance;
            string answer = "YES";
            for (long i = 0; i < n; i++)
            {
                //Console.WriteLine($"--{i + 1}th rop--");
                string[] inputStrArray = Console.ReadLine().Split(' ');
                lTime = long.Parse(inputStrArray[0]) - lTime;
                lX = long.Parse(inputStrArray[1]) - lX;
                lY = long.Parse(inputStrArray[2]) - lY;
                lDistance = Math.Abs(lX) + Math.Abs(lY);
                //Console.WriteLine($"lX, lY, lTime,lDistance; {lX}, {lY}, {lTime}, {lDistance}");
                if (lDistance % 2 != lTime % 2 || lTime <lDistance)
                {
                    answer = "No";
                    //Console.WriteLine("No Go");
                    break;
                }
            }

            Console.WriteLine(answer);
            Console.Out.Flush();
        }
    }
}
