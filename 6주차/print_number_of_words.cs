using System;
using static System.Console;

namespace MobileSW_6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string input = ReadLine(); // cin
            input = input.Trim(); // 공백 제거

            // 중간 공백이 하나 이상일 때 하나로 만들어주는 과정
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // split
            string results = string.Join(" ", words);
            //////////////////////////////////////////////////
         
            // 단어를 분리
            string[] result = results.Split(' ');

            // 단어 카운트 변수 할당
            int count_words = 0;

            foreach (string str_i in result)
            {
                // 대문자화
                string front_str = str_i.ToUpper();
                // 첫글자를 제외한 문자는 소문자화
                string back_str = str_i.Remove(0, 1).ToLower();
                
                // 단어 카운트
                count_words++;

                // 대문자 단어와 나머지 단어를 출력 (앞 글자만 대문자가 됨)
                WriteLine($"{front_str[0]}{back_str}");
            }
            // 총 단어의 개수를 출력
            WriteLine(count_words + "개");
        }
    }
}
