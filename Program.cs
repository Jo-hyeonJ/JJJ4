// 컨+쉬+/ : 영역 주석 단축키

// 입력함수와 switch
/*
Console.WriteLine("1. A문항이다.");
Console.WriteLine("2. B문항이다.");
Console.WriteLine("3. C문항이다.");

// 입력 함수
// ReadLine : 한 줄을 읽어서 string 값으로 반환한다.

// 프로그램 <-> 입력 버퍼(임시 공간) <-> 윈도우(OS)
// - 입력무하면 프로그램은 입력 버퍼를 감시한다.
// - ReadLine은 한 줄 읽기이므로 구분자인 \n(한 줄 띄우기)가 입력될 때까지 대기한다.

// int.Parse의 문제점
// = int 형으로 변환 할 수 없는 값이 대입되면 에러를 일으킨다.

// TryParse(문자열, out 숫자를 대입받을 변수)
// 만약 문자열을 숫자로 변환 할 수 없다면 무시한다.
int select = 0;
int.TryParse(Console.ReadLine(), out select); // 변환 할 수 없다면 무시하는 구문

string input = String.Empty;
// 입력문이 반환한 string값을 Parse 함수를 통해 int형으로 변환 후 대입했다.
select = int.Parse(input);

Console.WriteLine($"입력 값은 {input}입니다.");



// switch 분기문
// = 조건값에 따라 case로 이동하고, break를 만나면 스위치문을 빠져나온다.


switch(select)
{
    case 1:
        Console.WriteLine("A문항에 대한 설명");
        break;
    case 2: // 스위치문은 break를 만나지 않으면 계속해서 읽는다. (중복 된 상황을 만들 때 사용 가능한 방법) 
    case 3:
        Console.WriteLine("C문항에 대한 설명");
        break;
    default: // case에 없는 값(상정 되지않은 경우의 수)이 들어왔을 때 ( = else)
        Console.WriteLine("잘못된 입력입니다.");
        break;
}
*/

// Read함수와 반복문
/*
// Read (한 글자만 읽는다.)
Console.Write("아무키나 입력하세요. :");
int input2 = Console.Read();
Console.WriteLine($"input2 : {input2}");

// 반복문
// = 동일한 행동을 반복시켜주는 방법

// While문
// = 특정한 조건이 거짓이 될 때까지 반복


int count = 0;
while (true)
{
    Console.WriteLine("Hello");
    count++;
    if(count > 10)
        break; // 이 또한 반복문을 탈출한다
}*/

// while문 과제와 do_while
/*
// Q. 사용자에게서 입력을 받는다.
// 입력한 문자가 exit까지 계속 입력을 받는다.

// 1. 사용자에게서 입력을 받는다.
// 2. 입력 받은 내용을 문자열 "exit"와 비교한다.
// 3. 만약 동일하지 않다면 1번부터 다시 시작한다
// 4. 만약 동일하다면 중단한다.

bool check = true;
string word;

// while (Console.ReadLine() != exit) 로 조건문을 체크할 수도 있다 
while (check)
{
    Console.WriteLine("exit를 입력하세요. 아니면 반복");
    word = Console.ReadLine();

    

        if (word == "exit")
        {
            break;
        }
        else if (word == "Exit")
        {
            break;
        }
        else if (word == "EXIT")
        {
            break;
        }
        else
        {
        Console.WriteLine("잘못 입력했습니다.");
        }
     

    switch (word)
    {
        case "exit":
        case "Exit":
        case "EXIT":
            check = false;
            break;
        default :
            Console.WriteLine("잘못 입력했습니다");
            break;
    }
}


// do-while문
// 조건문 체크보다 실행문을 선행하는 반복문
// = 실행문을 최소 한번은 실행

do
{
    Console.WriteLine("do_while문");
}
while (false);
*/

// 지역변수와 for문
/*
// 값 형 변수의 특징
// = 특정 지역에서 탄생한 변수는 해당 지역이 끝나면 사라진다.

while (false)
{
    int count = 0; // 반복문 내부에서 무한히 선언됨
    count++;
    Console.WriteLine("Hello");
    if (count > 10)
        break;
}
// Console.WriteLine(count); 해당 시점에서 count 변수는 사라진다.

// for문 => 반복 횟수가 정해져있는 반복문
// 중괄호가 없으면 바로 아래에 있는 한 줄만 반복한다.
for (int i = 0; i < 5; i++)   
    Console.WriteLine($"Hello{i}");


// Q. for문을 이용해서 1~10까지 더한 수를 출력해보자.

int result = 0;
for (int i = 1; i <= 10; i++)
{
    result += i;
}
Console.WriteLine(result);
*/

// goto와 continue, return + foreach문
/*
goto JUMP;

for (int i = 0; i<10; i++)
{
    if (i == 3)
    {
    // continue
    // 이번 루프를 종료하겠다.
        continue;
    }

    // return : 함수를 종료한다.
    if (i == 4)
        return; // 여기선 Main 함수를 종료함
    Console.WriteLine(i);

}

// goto문
// = 코드의 흐름을 무시하고 원하는 지점으로 점프한다.
// 코드의 흐름을 무시하기 때문에 불완전해질 가능성이 있어 선호 되지 않는다.

JUMP:

Console.WriteLine("점프 도착");

// for-each문
// = 열거자의 내부를 순회하는 반복문

// 배열 맛보기
// = 한번에 여러개의 값을 담을 수 있는 변수
int[] array = new int[] { 1, 2, 3, 4, 5 };

// foreach + 변수 선언 + in + 열거자
// 열거자의 요소가 선언한 변수에 대입 된다.
foreach(int num in array)
{
    Console.WriteLine($"num의 값은 : {num}");
}*/