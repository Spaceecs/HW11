using HW11;
using System.Runtime.CompilerServices;

bool Fib(int num)
{
    int a = 0;
    int b = 1;
    while (b < num)
    {
        int temp = b;
        b += a;
        a = temp;
    }
    return b == num;
}
int WCount(string str)
{
    string[] strArr = str.Split(" ");
    return strArr.Length;
}
int LWLength(string str)
{
    string[] strArr = str.Split(" ");
    string lword = strArr[strArr.Length - 1];
    return lword.Length;
}
bool Validator(string str)
{
    Stack<char> stack = new Stack<char>();

    foreach (char ch in str)
    {
        if (ch == '(' || ch == '{' || ch == '[')
        {
            stack.Push(ch);
        }
        else if (ch == ')' || ch == '}' || ch == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }

            char opening = stack.Pop();
            if ((ch == ')' && opening != '(') ||
                (ch == '}' && opening != '{') ||
                (ch == ']' && opening != '['))
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}
int[] MinMaxTemp(int[] temp)
{
    int min = temp[0];
    int max = temp[0];
    foreach (int i in temp)
    {
        if (i<min)
        {
            min = i;
        }
        if (i>max)
        {
            max = i;
        }
    }
    int[] MinMax = [min, max];
    return MinMax;
}


//Task 1

Console.Write("Enter Num: ");
int num;
Int32.TryParse(Console.ReadLine(), out num);
Predicate<int> pred = new Predicate<int>(Fib);
Console.WriteLine($"Result : {pred(num)}");

//Task 2

Console.WriteLine("Enter string: ");
string str = Console.ReadLine();
Func<string, int> func = new(WCount);
int res = func(str);
Console.WriteLine($"Result : {res}");

//Task 3

Func<string, int> func2 = new(LWLength);
Console.WriteLine("Enter string: ");
str = Console.ReadLine();
res = func2(str);
Console.WriteLine($"Result : {res}");

//Task 4

Console.WriteLine("Enter string: ");
str = Console.ReadLine();
Predicate<string> predicate = new(Validator);
Console.WriteLine($"Result : {predicate(str)}");

//Task 5

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] evenNumbers = numbers.Filter(num => num % 2 == 0);
Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
int[] oddNumbers = numbers.Filter(num => num % 2 != 0);
Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

//Task 6

Random rand = new Random();
int[] temp = new int[10];
for (int i=0;i<temp.Length;++i)
{
    temp[i] = rand.Next(-40, 40);
}
foreach(int i in temp)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Func<int[], int[]> func3 = new(MinMaxTemp);
int[] minmax = func3(temp);
DaylyTemperature dayly = new(minmax[0], minmax[1]);
Console.WriteLine(dayly.ToString());

//Task 7

StudentGrades student = new StudentGrades { StudentName = "John", Grades = [10, 12, 8] };
Func<int> func1 = new(student.MaxGrade);
int maxGrade = func1();
Func<double> func4 = new(student.AverageGrade);
double averageGrade = func4();
Console.WriteLine($"Max Grade {student.StudentName}: {maxGrade}");
Console.WriteLine($"Average Grade {student.StudentName}: {averageGrade}");