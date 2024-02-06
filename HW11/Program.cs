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

//Task 1

Console.Write("Enter Num: ");
int num;
Int32.TryParse(Console.ReadLine(),out num);
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