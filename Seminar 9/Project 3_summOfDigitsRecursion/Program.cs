Console.WriteLine("Программа считающая сумму цифр в числе");

// функция проверки ввода
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

int SumOfDigits(int n)
{
    
    if (n == 0) return 0;
    return n%10 + SumOfDigits(n / 10);
    
}


Console.WriteLine("Введите целое число (N): ");
int number = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");

Console.WriteLine($"Сумма цифр в числе: {SumOfDigits(number)}");