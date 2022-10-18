Console.WriteLine("Введите число программистов в комнате: ");
int number = int.Parse(Console.ReadLine()!);

string Programmers(int number)
{
    string prog = "программист";
    if (number > 10 & number < 19)
    {
        prog = string.Concat(prog, "ов");
    }
    else
    {
        int numberTemp;
        numberTemp = number % 10;
        //string prog = "программист";
        if (numberTemp == 1)
        {
            prog = prog;
        }
        if (numberTemp > 1 && numberTemp < 5)
        {
            prog = string.Concat(prog, "а");
        }
        if (numberTemp == 0 || numberTemp > 4)
        {
            prog = string.Concat(prog, "ов");
        }
    }
    return prog;
}

Console.Write("В комнате " + number + " " + Programmers(number));
