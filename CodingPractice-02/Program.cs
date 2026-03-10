using System;
using static System.Console;
// README.md를 읽고 아래에 코드를 작성하세요.




// 1

// Function 델리게이트는 <> 맨뒤의 데이터형이 반환형, 앞이 매개변수.
// 매개변수가 없는 int 반환형 Func
Func<int> getNumber = () => 1234;
WriteLine(getNumber());
// 매개변수가 int형, 반환형도 int형
Func<int, int> square = (int a) => a * a;
WriteLine(square(3));
// 매개변수가 int형 2개, 반환형 int 
Func<int, int, int> addNumber = (int a, int b) => a + b;
WriteLine(addNumber(3, 5));

// 2

// 받는 매개변수가 없고(), 그냥 WriteLine(내용물)을 출력하는 메서드 hello();
Action hello = () => WriteLine("안녕하세요!");
hello();
//  <> 안에 입력받을 수 있는 타입
// 현재 입력 타입은 string
// string 을 받을 수 있는 함수 print 는 message (=> 좌측)를 매개변수로 받아서
// 내용물인 WriteLine(매개변수) 를 하는 형태
Action<string> print = message => WriteLine(message);
print("앙기모띠");

WriteLine();

// 3
Func<int, int> anonymous = delegate (int x) { return x * x; };
WriteLine(anonymous(2));

Func<int, int> lambda = x => x * x;
WriteLine(lambda(2));

WriteLine();

// 4




