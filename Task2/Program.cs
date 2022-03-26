int Prompt(string message)
{
    Console.WriteLine(message);
    string strquart = Console.ReadLine();
    int quarter = int.Parse(strquart);
    return quarter;
}

double x1 = Prompt("Введите первый x ");
double y1 = Prompt("Введите первый y ");
double x2 = Prompt("Введите второй x ");
double y2 = Prompt("Введите второй y ");
double z1 = Prompt("Введите первый z ");
double z2 = Prompt("Введите второй z ");

double x3 = x2 - x1;
double y3 = y2 - y1;
double z3 = z2 - z1;

double S = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2));

Console.WriteLine(S);
