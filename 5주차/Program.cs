//using System;
//using static System.Console;

//namespace FirstCSharp
//{
//    class HelloWorld
//    {
//        // 프로그램 실행이 시작되는 곳
//        static void Main(string[] args)
//        {
//            if (args.Length == 0)
//            {
//                WriteLine("사용법 : HelloWorld.exe<이름>");
//                return;
//            }

//            WriteLine("Hello, {0}!", args[0]);
//        }
//    }
//}

using System;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calculator.Plus(3, 4));
            //Console.WriteLine(Calculator.Minus(3, 4));

            float a  = 123.45678901234f;
            float a1 = 123.45678901235f;
            Console.WriteLine("a : {0}", a); // 123.4568 출력
            Console.WriteLine("a1 : {0}", a1); // 123.4568 출력
            if (a == a1) Console.WriteLine("a is a1");
            else Console.WriteLine("a is not a1");

            float c  = 0.2f - 0.1f;
            float c1 = 45.45f - 45.35f;

            Console.WriteLine("c = {0}, c1 = {1}", c, c1);

            decimal a2 = 123.45678901234m;
            decimal a3 = 123.45678901235m;

            Console.WriteLine("a2 : {0}, a3 : {1}", a2, a3);

        }
    }

}
