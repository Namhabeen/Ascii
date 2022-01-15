#Ascii

🙂알파벳 소문자, 대문자, 숫자 0-9중 하나가 입력 되었을 때, Input값의 아스키코드 번호를 출력하는 방법 <br>
🙂사실 가장 간단하게 작성한다면! 아래처럼 작성하면 끝나겠지만 조금 더 파고 들어가보았습니다 :D
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

🙂현재 제 소스에서 보완하고 싶은 점은 Unhandled exception 처리 부분 입니다!<br>
