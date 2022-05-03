using System;

namespace ConsoleApp9
{
    class Data
    {
        public string name;
        public int year = 2022;
        public string major = "임베디드";

        public Data()
        {
            this.name = "Error";
        }

        public Data(string name)
        {
            this.name = name;
        }
        public Data(string name, int year) : this(name)
        {
            this.year = year;
        }
        public Data(string name, int year, string major) : this(name, year)
        {
            this.major = major;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data[] student = new Data[10];

            student[0] = new Data("강하늘", 2022, "경제");
            student[1] = new Data("염하늘", 2021, "임베디드");
            student[2] = new Data("유강하", 2020, "경영");
            student[3] = new Data("한대희", 2019, "수학");
            student[4] = new Data("김준영", 2018, "화학");
            student[5] = new Data("이준영", 2022, "정보통신");
            student[6] = new Data("태지원", 2021, "컴퓨터");
            student[7] = new Data("김길준", 2020, "기계");
            student[8] = new Data("모태훈", 2029, "전자");
            student[9] = new Data("이태훈", 2022, "영어교육");
            
            // 입학연도와 학과를 지정하지 않은경우 default 값인 2022, 임베디드가 지정됩니다.
            // student[9] = new Data("이태훈");

            // 이름을 입력하지 않은경우 프로그램이 종료됩니다.
            // student[9] = new Data();

            int input_year = 2022;

            for (int i = 0; i < 10; i++)
            {
                if (student[i].name == "Error")
                {
                    Console.WriteLine("E : 이름을 입력하지 않았습니다. 프로그램을 종료합니다.");
                    return;
                }
            }

            Console.WriteLine("{0}년에 입학한 학생의 정보입니다.", input_year);
            for (int i = 0; i < 10; i++)
            {
                if (student[i].year == input_year)
                {
                    Console.WriteLine(student[i].name + " 학생은 " + student[i].major + "학과에 " + student[i].year + "년에 입학했습니다.");
                }
            }
        }
    }
}
