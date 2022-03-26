Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine();

int IntNumber = int.Parse(Number);

string MirNum(string arg1)
{
   string MirNumber = ($"{arg1[4]}{arg1[3]}{arg1[2]}{arg1[1]}{arg1[0]}");
   return MirNumber; 
}

string MinMirNum(string arg1)
{
    string MinMirNumber = ($"{arg1[0]}{arg1[5]}{arg1[4]}{arg1[3]}{arg1[2]}{arg1[1]}");
    return MinMirNumber;
}

string Num2 = ("");

string res = ("");

string result = (N2(Number));

string N2(string N)
{
    if (IntNumber > 0)
    {
        if (IntNumber > 99999 || IntNumber < 10000)
        {
            res = ("Это не пятизначное число");
        }
        else
        {
            Num2 = MirNum(N);
            if (Number == Num2)
            {
                res = ("Да");
            }
            else
            {
                res = ("Нет");
            }
        }
    }
    else 
    {
        if (IntNumber > -10000 || IntNumber < -99999)
        {
            res = ("Это не пятизначное число");
        }
        else
        {
            Num2 = MinMirNum(N);
            if (Number == Num2)
            {
                res = ("Да");
            }
            else
            {
                res = ("Нет");
            } 
        }
    }
    return res;
}    

Console.WriteLine(result);