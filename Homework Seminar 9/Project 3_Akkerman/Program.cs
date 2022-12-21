Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии");

// функция проверки ввода
int InputCheck()
{
    int inputValue;
    NewInput:
    while ((!int.TryParse(Console.ReadLine()!, out inputValue))) //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение
    {
        Console.WriteLine("Неверный ввод. Введите целое неотрицательное число");
        Console.WriteLine("Введите число заново: ");
    }
    if (inputValue < 0)
    {
        Console.WriteLine("Неверный ввод. Введите целое неотрицательное число");
        Console.WriteLine("Введите число заново: ");
        goto NewInput;
    }
    return inputValue;
}

double Akkerman(double n, double m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}

Console.WriteLine("Введите первый аргумент функции Аккермана (n): ");
int argN = InputCheck(); // введем число и проверим ввод

Console.WriteLine("Введите второй аргумент функции Аккермана (m): ");
int  argM = InputCheck(); // введем число и проверим ввод

Console.WriteLine($"Результат вычисления функции Аккермана от ({argN},{argM}): {Akkerman (argN,argM)}");