Console.WriteLine(
    "Программа выводящая все натуральные числа в промежутке от N до 1 через рекурсию"
);

// функция проверки ввода
int InputCheck()
{
    int inputValue;
    NewInput:
    while ((!int.TryParse(Console.ReadLine()!, out inputValue))) //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение
    {
        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    if (inputValue < 0)
    {
        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
        goto NewInput;
    }
    return inputValue;
}

void Sequence(int n)
{
    if (n == 0)
    {
        return;
    }
    if (n == 1)
    {
        Console.Write($"{n}");
    }
    else
    {
        Console.Write($"{n}, ");
    }

    Sequence(n - 1);
}

Console.WriteLine("Введите количество элементов последовательности (N): ");
int number = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Sequence(number);
