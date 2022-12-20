Console.WriteLine("Программа выводящая все натуральные числа в промежутке от M до N через рекурсию");

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

void Sequence(int n, int m)
{
    if (n<m) return;
    if (n>m)
    {
       Sequence(n-1, m); 
    }
    if (n==m)
    {
       Console.Write($"{n}"); 
    }
    else
    {
        Console.Write($", {n}");
    }
}


Console.WriteLine("Введите конечный элемент последовательности (N): ");
int number = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Console.WriteLine("Введите начальный элемент последовательности (M): ");
int numberM = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Sequence(number, numberM);