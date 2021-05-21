using AtCoder.Abc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


                Exec(args);
                Console.WriteLine("============ Retry  ============");
                Console.Out.Flush();
            }
        }

        private static void Exec(string[] args)
        {
            //実行するcllass指定
            Otoshidama.Main(args);
        }

        public class Debug
        {
            public static void Log(string message)
            {
                Console.WriteLine("DEBUG: " + message);
            }
        }
    }
}
