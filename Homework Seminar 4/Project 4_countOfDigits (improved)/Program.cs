Console.WriteLine("Программа подсчета количества цифр в числе");

// функция проверки ввода
double InputCheck()
{
    double inputValue;
    while ((!double.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    {

        Console.WriteLine("Неверный ввод. Введите число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

double DigitsCounter(double N)
{
    int count = BitConverter.GetBytes(decimal.GetBits((decimal)N)[3])[2]; // я вообще не понял как это работает. магия какая-то
    N = N * Math.Pow(10, count);
    double res = Math.Floor(Math.Log10(N) + 1); // узнаем длину числа. MathFloor - округляет результат вычисления логарифма до ближайшего целого числа в сторону минус бесконечности
return res;
}
Console.WriteLine("Введите число: ");
double N = InputCheck(); // введем число N и проверим ввод

Console.WriteLine($"Количество цифр в числе: {DigitsCounter(N)} ");