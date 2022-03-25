int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

int Number = Parse("Введите пятизначное число: ");

string num2(int arg1)
{
    int N1 = arg1 / 10000;
    int N2 = arg1 / 1000 - N1 * 10;
    int N3 = arg1 / 100 - N2 * 10 - N1 * 100;
    int N4 = arg1 % 100 / 10;
    int N5 = arg1 % 10;
    string mirr = ($"{N5}{N4}{N3}{N2}{N1}");
    return mirr;
}

string MinNum2(int arg1)
{
    int N1 = arg1 / 10000;
    int N2 = arg1 / 1000 - N1 * 10;
    int N3 = arg1 / 100 - N2 * 10 - N1 * 100;
    int N4 = arg1 % 100 / 10;
    int N5 = arg1 % 10;
    string mirr = ($"{N5}{-N4}{-N3}{-N2}{-N1}");
    return mirr;
}

string Number2 = ("");

if (Number > 0)
{
    Number2 = num2(Number);
}
else
{
    Number2 = MinNum2(Number);
}

string Number3 = ($"{Number}");


if (Number > 0)
{
    if (Number > 99999 || Number < 10000)
    {
        Console.WriteLine("Это не пятизначное число");
    }
    else
    {
        if (Number3 == Number2)
        {
            Console.WriteLine("Да");
        }
       else 
        {
            Console.WriteLine("Нет");
        }
    }
}
else
{
    if (Number > -10000 || Number < -99999)
    {
        Console.WriteLine("Это не пятизначное число");
    }
    else
    {
        if (Number3 == Number2)
        {
            Console.WriteLine("Да");
        }
       else 
        {
            Console.WriteLine("Нет");
        }
    }
}