using System;

namespace ConsoleAppMiddleTest
{
    class GUGU
    {
        public static int n;
        public static int m;
        private int G;

        public GUGU (int num)
        {
            // 생성시 정수 G값을 만든다.
            G = num;

            for (int i = 1; i<=n; i++)
            {
                Console.Write("{0}*{1} = {2,2}      ", i, G, i * G);

                // 한 줄에는 m개 씩 출력됩니다.
                if (i % m == 0) Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // n과 m은 임의로 바꿉니다.
            GUGU.n = 7;
            GUGU.m = 3;

            GUGU gugudan = new GUGU(9);
        }
    }
}
