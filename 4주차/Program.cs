using System;

namespace FirstCSharp
{
    class HelloWorld
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe<이름>");
                return;
            }

            Console.WriteLine("Hello, {0}!", args[0]);
        }
    }
}