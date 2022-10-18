Console.WriteLine("Введите номер дня недели ");
int number;
while (!int.TryParse(Console.ReadLine()!, out number))
{
    Console.WriteLine("Повтортие ввод. Неверное значение ");
    Console.WriteLine("Введите номер дня недели ");
}

bool Weekends(int number)

{
    bool wEnds = false;
    if (number == 6 || number == 7)
    {
        wEnds = true;
    }
    return wEnds;
}

Console.WriteLine("День недели выходной? " + Weekends(number));

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет