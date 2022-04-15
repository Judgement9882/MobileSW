using System;

namespace FirstCSharp_7
{

    

    class Animal
    {

        public static int count = 0;
        string name;
        public Animal(string name)
        {
            this.name = name;
            Console.WriteLine(count);
            count++;
        }

        public static void StaticMethod()
        {
            Console.WriteLine("정적 메소드 출력, 이건 클래스 인스턴스 만들지 않아도 동작");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal.count = 10;
            Animal.StaticMethod();

            Animal a = new Animal("사자");
            Animal.count = 20;
            Animal b = new Animal("사자");

            // a.StaticMethod() // 쓸수없음
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(Animal.count);
            // Console.WriteLine(a.count); // 쓸 수 없음
        }
    }
}
