using System;

namespace ConsoleAppMiddleTest
{
    class UNIV
    {
        private int a;
        public static int b;
        public static int c;
        public int res;

        // 전체 인스턴스 개수를 카운트하는 변수
        public static int count_UNIV=0;

        public UNIV (int a)
        {
            this.a = a;
            Console.WriteLine(a * (b + c));
            res = a * (b + c);

            // 생성될 때 마다 인스턴스를 카운트 합니다.
            count_UNIV++;
        }

        public static void Sum(int m, int n)
        {
            Console.WriteLine(m + n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // b와 c는 임의로 바꿉니다.
            int b = 5;
            int c = 15;

            UNIV.b = b;
            UNIV.c = c;
            
            Console.WriteLine(b);
            Console.WriteLine(c);
            UNIV.Sum(b, c);

            UNIV univ_a = new UNIV(3);
            UNIV univ_b = new UNIV(4);
            // 인스턴스를 여러개 생성하여도 카운트 됩니다.
            //UNIV univ_c = new UNIV(4);
            //UNIV univ_d = new UNIV(5);
            //UNIV univ_e = new UNIV(6);

            if (univ_a.res.Equals(univ_b.res))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            
            // 전체 인스턴스 생성 개수를 출력합니다.
            Console.WriteLine(UNIV.count_UNIV);
        }
    }
}
