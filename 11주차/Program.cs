// 인터페이스 사용하기(상속받으면 그 클래스에서 프로퍼티 무조건 구현해야함)

using System;

namespace ConsoleApp11
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    class NameValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue() {Name = "이름", Value = "아연맨" };
            NameValue height = new NameValue() { Name = "키", Value = "170cm" };
            NameValue weight = new NameValue() { Name = "몸무게", Value = "65kg" };

            Console.WriteLine("{0} : {1}", name.Name, name.Value);
            Console.WriteLine("{0} : {1}", height.Name, height.Value);
            Console.WriteLine("{0} : {1}", weight.Name, weight.Value);

        }
    }
}


// 객체 생성할때 초기화 하는 방식

//using System;

//namespace ConsoleApp11
//{
//    class BirthdayInfo
//    {
//        //private string name;
//        // private DateTime birthday;

//        public string Name { get; set; }
//        public DateTime Birthday { get; set; }

//        public int Age
//        {
//            // 프로퍼티의 구현에는 메소드등 코드를 넣을 수 있다.
//            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
//        }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {

////            BirthdayInfo birth = new BirthdayInfo();
////            birth.Name = "배추도사";
////            birth.Birthday = new DateTime(1990, 6, 28);

//            BirthdayInfo birth = new BirthdayInfo()
//            {
//                Name = "배추도사",
//                Birthday = new DateTime(1990, 6, 28)
//            };

//            // 무명 형식 ================================
//            var a = new { Name = "배추도사", Age = 30 };
//            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 85, 95 } };

//            Console.WriteLine("Name : {0}, Age : {1}", a.Name, a.Age);
//            Console.Write("Subject : {0}, Scores: ", b.Subject);
//            foreach(var score in b.Scores)
//            {
//                Console.Write("{0} ", score);
//            }
//            Console.WriteLine();

//            // 무명 형식 ================================

//            Console.WriteLine("Name : {0}", birth.Name);
//            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
//            Console.WriteLine("Age : {0}", birth.Age);
//        }
//    }
//}


// 프로퍼티를 선언할 때 기본기능이라면 시작부터 초기화시키기
//using System;

//namespace ConsoleApp11
//{
//    class BirthdayInfo
//    {
//        //private string name;
//        // private DateTime birthday;

//        public string Name { get; set; }
//        public DateTime Birthday { get; set; }

//        public int Age
//        {
//            // 프로퍼티의 구현에는 메소드등 코드를 넣을 수 있다.
//            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
//        }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo();
//            birth.Name = "배추도사";
//            birth.Birthday = new DateTime(1990, 6, 28);

//            Console.WriteLine("Name : {0}", birth.Name);
//            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
//            Console.WriteLine("Age : {0}", birth.Age);
//        }
//    }
//}

// 프로퍼티 안에 기능을 추가한 예제
//using System;

//namespace ConsoleApp11
//{
//    class BirthdayInfo
//    {
//        private string name;
//        private DateTime birthday;

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public DateTime Birthday
//        {
//            get { return birthday; }
//            set { birthday = value; }
//        }

//        public int Age
//        {
//            // 프로퍼티의 구현에는 메소드등 코드를 넣을 수 있다.
//            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
//        }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo();
//            birth.Name = "배추도사";
//            birth.Birthday = new DateTime(1990, 6, 28);

//            Console.WriteLine("Name : {0}", birth.Name);
//            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
//            Console.WriteLine("Age : {0}", birth.Age);
//        }
//    }
//}

// 프로퍼티 사용예제
//using System;

//namespace ConsoleApp11
//{
//    class MyClass
//    {
//        private int myField;
//        public int MyField
//        {
//            get
//            {
//                return myField;
//            }
//            set
//            {
//                myField = value;
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            obj.MyField = 3;

//            Console.WriteLine(obj.MyField);
//        }
//    }
//}

// 평상시 코드
//using System;

//namespace ConsoleApp11
//{
//    class MyClass
//    {
//        private int myField;
//        public int GetMyField()
//        {
//            return myField;
//        }

//        public void SetMyField(int NewValue)
//        {
//            myField = NewValue;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            obj.SetMyField(3);

//            Console.WriteLine(obj.GetMyField());
//        }
//    }
//}