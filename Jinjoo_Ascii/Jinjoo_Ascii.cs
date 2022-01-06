using System;

namespace Jinjoo_Ascii
{
    class CharToAscii
    {
        static void Converter()
        {
            //문제에 "하나"라고 명시되어 char 사용
            //char input = char.Parse(Console.ReadLine());도 사용 가능하지만 조건에 null이 입력된다는 부분이 명시되어 있지 않음으로 
            //null 값이 입력되는 경우 알아서 예외처리를 하는  Parse 대신 Toint32 사용
            char input = Convert.ToChar(Console.ReadLine());
            int output = Convert.ToInt32(input);
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            Converter();
        }
    }
}
