using System;

namespace Jinjoo_Ascii
{
    class CharToAscii
    {
        static void Converter()
        {
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
