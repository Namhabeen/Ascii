using System;
using System.Text.RegularExpressions;

namespace Ascii
{
    class CharToAscii
    {
        static void Converter()
        {
            //문제에 "하나"라고 명시되어 char 사용
            //char input = char.Parse(Console.ReadLine());도 사용 가능하지만 조건에 null이 입력된다는 부분이 명시되어 있지 않음으로 
            //null 값이 입력되는 경우 알아서 예외처리를 하는  Parse 대신 Toint32 사용
            char input = Convert.ToChar(Console.ReadLine());

            //boolean 타입으로 조건검사
            bool checkInput1 = Regex.IsMatch(input.ToString(), "[a-z]", RegexOptions.IgnoreCase);
            bool checkInput2 = (int)Char.GetNumericValue(input) > -1 && (int)Char.GetNumericValue(input) < 10;

            //알파벳 인지 OR 숫자 0-9가 맞는지 체크하는 조건문
            if (checkInput1 || checkInput2)
            {
                //값을 32비트 정수로 Convert
                int output = Convert.ToInt32(input);
                //입력값의 아스키 코드번호 출력
                Console.WriteLine(output);
            }

            //만약 '/'가 입력된다면 프로그램 종료
            else if (input == '/')
            {
                //종료문구 출력
                Console.WriteLine("프로그램이 종료됩니다!");
                //메서드 종료
                return;
            }

            //조건을 충족하지 못하는 값 또는 '/'가 아닌 값이 입력 된 경우
            else
            {
                //콘솔 창의 문구를 빨간글씨로 설정해 아래의 문구가 더 눈에 들어오도록 설정
                Console.ForegroundColor = ConsoleColor.Red;

                //문제의 조건을 충족하지 않는 경우 콘솔 창에 띄우는 문구
                Console.WriteLine("알파벳 소문자, 대문자, 숫자 0-9 중 하나를 입력해주세요!");

                //콘솔 창의 글자 컬러 리셋
                Console.ResetColor();

                //조건에 맞는 값이 입력될 때 까지 메서드가 반복되어 실행되도록 함. 
                Converter();
            }
        }

        static void Main(string[] args)
        {
            //Main 메서드에서 Convert 메서드 호출
            Converter();
        }
    }
}
