using System;
using System.Collections.Generic;
using static System.Console;
// README.md를 읽고 아래에 코드를 작성하세요.

// predicate 대리자
// 조건 검사후 bool 반환하는 대리자
// 

// 1

// step 1 - 숫자를 찾을 메서드 만들기
// step 2 - 메서드 내부구조 만들기
// step 3 - 3의 배수 조건 검사하기

// 정수(int) 목록을 반환하는 FindNumbers 라는 함수
// 매개변수 : int(정수)를 받아서 bool 값을 반환하는 함수
// predicate : 조건이 맞는지를 검사하고 bool을 반환하는 대리자 (delegate)
static List<int> FindNumbers (Predicate<int> predicate)
{
    // 리스트형 result 변수 선언
    List<int> result = new();

    for (int i = 1; i <= 100; i++)
    {
        if (predicate(i))
        {
            // Add 는 List타입에 값을 추가해주는 메서드
            // List와 사용가능한 기능
            result.Add(i);
        }
    }
    return result;
}
// 3의 배수 찾기
var multipleofThree = FindNumbers(n => n % 3 == 0);
WriteLine("3의 배수:");
foreach (var n in multipleofThree)
{
    Write($"{n} ");

}
WriteLine();

// 제곱수 찾기
var perfectSquares = FindNumbers(n =>
{
    int sqrt = (int)Math.Sqrt(n);
    return sqrt * sqrt == n;
});
WriteLine("제곱수:");
foreach (var n in perfectSquares)
{
    Write($"{n} ");
}
WriteLine();


WriteLine();

// 2 predicate 대리자
Predicate<int> IsEven = n => n % 2 == 0;
Func<int, bool> IsOdd = a => a % 2 == 1;

WriteLine(IsEven(4));
WriteLine(IsOdd(4));

WriteLine();


// 3
int factor = 2;

Func<int, int> multiplier = n => n * factor;
WriteLine(multiplier(3));

factor = 10;
WriteLine(multiplier(3));

WriteLine();

// 4
{
    int count = 0;

    Action increment = () => count++;

    increment();
    increment();
    increment();

    WriteLine($"{count}");
}

WriteLine();


// 5

var counter = CreateCounter();
WriteLine(counter());
WriteLine(counter());
WriteLine(counter());
static Func<int> CreateCounter()
{
    int count = 0;
    return () => count++;
}

