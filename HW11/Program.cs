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