# Ascii

πμνλ²³ μλ¬Έμ, λλ¬Έμ, μ«μ 0-9μ€ νλκ° μλ ₯ λμμ λ, Inputκ°μ μμ€ν€μ½λ λ²νΈλ₯Ό μΆλ ₯νλ λ°©λ² <br>
πμ¬μ€ κ°μ₯ κ°λ¨νκ² μμ±νλ€λ©΄! μλμ²λΌ μμ±νλ©΄ λλκ² μ§λ§ μ‘°κΈ λ νκ³  λ€μ΄κ°λ³΄μμ΅λλ€ :D
<pre><code>using System;

namespace Ascii<br>
{
    class CharToAscii<br>
    {
        static void Main(string[] args)
        {
           char input = Convert.ToChar(Console.ReadLine());
           int output = Convert.ToInt32(input);
           Console.WriteLine(output);
        }
    }
}</code></pre>

<pre><code>using System;

namespace Ascii<br>
{
    class CharToAscii<br>
    {
        static void Main(string[] args)
        {
           char input = Convert.ToChar(Console.ReadLine());
           Console.WriteLine((int)input);
        }
    }
}</code></pre>

πνμ¬ μ  μμ€μμ λ³΄μνκ³  μΆμ μ μ Unhandled exception μ²λ¦¬ λΆλΆ μλλ€!<br>
