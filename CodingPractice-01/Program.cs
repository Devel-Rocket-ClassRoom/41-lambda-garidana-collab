using System;
using System.Threading;
using static System.Console;



// README.md를 읽고 아래에 코드를 작성하세요.



// 1

// PrintMessage 
PrintMessage hello = () => WriteLine("안녕하세요");


hello();

WriteLine();

// 2

Transformer square = x => x * x;

WriteLine(square(3));
WriteLine(square(4));


WriteLine();

// 3

IsLonger islong = (string msg, int len) => msg.Length > len;

WriteLine(islong("안녕하세요.", 5));
WriteLine(islong("반갑습니다", 10));

WriteLine();

// 4
Greeting greeting = () =>
{
    WriteLine("안녕하세요");
    WriteLine("반갑습니다.");
};

greeting();

WriteLine();

// 5
Calculator add = (a, b) =>
{
    int result = a + b;
    WriteLine($"{a} + {b} = {result}");
    return result;
};

int sum = add(3, 5);
WriteLine($"합계: {sum}");

WriteLine();






delegate int Transformer(int i);
delegate void PrintMessage();
delegate bool IsLonger(string s, int i);
delegate void Greeting();
delegate int Calculator(int a, int b);