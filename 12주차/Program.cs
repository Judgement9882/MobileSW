// finally 포함 예제

using System;

namespace ConsoleApp12
{
    class Program
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return divisor / dividend;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("제수를 입력하세요. :");
                String temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요. :");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.WriteLine("{0} / {1} = {2}", divisor, dividend, Divide(divisor, dividend));
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("zero 에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}

// try catch, throw 예제

//using System;

//namespace ConsoleApp12
//{
//    class Program
//    {
//        static void DoSomething(int arg)
//        {
//            if (arg < 10)
//            {
//                Console.WriteLine($"arg : {arg}");
//            }
//            else
//            {
//                throw new Exception("arg가 10보다 큼");
//            }
//        }


//        static void Main(string[] args)
//        {
//            int[] index = new int[6] { 1, 3, 5, 7, 9, 11 };
//            try
//            {
//                foreach (int i in index)
//                {
//                    DoSomething(i);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
