using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AtCoder.Abc
{
    class SomeSums
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

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long N = inputLongArray[0];
            long A = inputLongArray[1];
            long B = inputLongArray[2];

            long answer = 0;
            long lN_sum = 0;

            for(long i = 1; i <= N; i++){
                long value = i;
                while (0 < value)
                {
                    lN_sum += (value % 10);
                    value = (value / 10); 
                }
                if(A  <= lN_sum && lN_sum <= B)
                {
                    answer += i;
                }   
                lN_sum = 0;
            }

            Console.WriteLine(answer);
            Console.Out.Flush();
        }
    }
}
