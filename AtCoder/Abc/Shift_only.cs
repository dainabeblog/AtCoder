﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class Shift_only
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            //string s = Console.ReadLine();

            // 整数の入力
            long lDataNum = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            bool bEvenFlag = true;
            long lCount = 0;
            long result = lCount;

            while (bEvenFlag)
            {
                for (long i = 0; i < lDataNum; i++)
                {
                    if(inputLongArray[i] % 2 != 0)
                    {
                        bEvenFlag = false;
                        Console.WriteLine(lCount);
                        break;
                    }
                    inputLongArray[i] = inputLongArray[i] / 2;
                }
                lCount++;
            }

            Console.Out.Flush();
        }
    }
}