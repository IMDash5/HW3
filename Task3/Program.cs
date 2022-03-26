int Prompt(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

int N = Prompt("Введите число ");

int i = 1;
double res = 0;

if (N > 0)
{
    while (i <= N)
    {
        res = Math.Pow(i, 3);
        Console.Write($"{res} ");
        i = i + 1;
    }
}
else 
{
    while (i >= N)
    {
        res = Math.Pow(i, 3);
        Console.Write($"{res} ");
        i = i - 1;
    }
}
