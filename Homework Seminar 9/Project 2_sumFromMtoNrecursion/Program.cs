Console.WriteLine("Программа подсчета суммы натуральных чисел в промежутке от M до N через рекурсию");

// функция проверки ввода
int InputCheck()
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue))) //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение
    {
        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

int Sequence(int n, int m)
{

    if (n == m)
    {
        return m;
    }
    else
    {
        return n + Sequence(n - 1, m);
    }
}

NewInput:
Console.WriteLine("Введите конечный элемент последовательности (N): ");
int numberN = InputCheck(); // введем число и проверим ввод

Console.WriteLine("Введите начальный элемент последовательности (M): ");
int numberM = InputCheck(); // введем число и проверим ввод
if (numberN < numberM)
{
    Console.WriteLine("Неверный ввод. Введите целое число");
    Console.WriteLine("Введите число заново: ");
    goto NewInput;
}
Console.WriteLine(" ");
int result = Sequence(numberN, numberM);
Console.WriteLine($"Cумма чисел от {numberM} до {numberN}: {result}");
