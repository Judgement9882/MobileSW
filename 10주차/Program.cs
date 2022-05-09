using System;

namespace ConsoleApp10
{
    class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i); // 글자 하나하나당 대문자면 소문자로 바꿔줌
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A~Z 의 ASCII 값 : 65 : 90
                {
                    return arr[i];
                }
                else // 소문자
                {
                    return (char)(arr[i] + 32);
                }
            }
            return new string(arr);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}

//using System;

//namespace ConsoleApp10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int value = Add(20, c: 15);
//            Console.WriteLine(value);

//        }

//        static int Add(int a, int b = 50, int c = 100)
//        {
//            return a + b + c;
//        }
//    }
//}

//using System;

//namespace ConsoleApp10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int value = Add(20, c: 15);
//            Console.WriteLine(value);

//        }

//        static int Add(int a, int b = 50, int c = 100)
//        {
//            return a + b + c;
//        }
//    }
//}
