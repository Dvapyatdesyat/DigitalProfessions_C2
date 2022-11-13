Console.WriteLine("Программа возведения числа А в степень числа B");
int InputCheck()
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    {

        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

double ExponentationAB (int A, int B)
{
    double result = (Math.Pow(A, B));
    return result;
}

Console.WriteLine("Введите A: ");
int A = InputCheck(); // введем число A и проверим ввод

Console.WriteLine("Введите B: ");
int B = InputCheck(); // введем число B и проверим ввод

Console.Write($"Результат: {ExponentationAB (A,B)}");
