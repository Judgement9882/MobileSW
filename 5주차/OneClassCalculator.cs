using System;
using static System.Console;

namespace CAL
{ 
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int int_a = Int32.Parse(args[1]);
                int int_b = Int32.Parse(args[2]);

                if (String.Compare(args[0], "PLUS") == 0)
                {
                    WriteLine("{0} + {1} = {2}", int_a, int_b, int_a + int_b);
                    return;
                }
                else if (String.Compare(args[0], "MINUS") == 0)
                {
                    WriteLine("{0} - {1} = {2}", int_a, int_b, int_a - int_b);
                    return;

                }
                else if (String.Compare(args[0], "MULTI") == 0)
                {
                    WriteLine("{0} * {1} = {2}", int_a, int_b, int_a * int_b);
                    return;
                }
                else // 연산자의 이름을 잘못 입력한 경우
                {
                    WriteLine("연산자의 이름을 잘못 입력했습니다.");
                    return;
                }

                return;
            }
            WriteLine("인자의 개수가 맞지 않습니다.");
        }
    }
}