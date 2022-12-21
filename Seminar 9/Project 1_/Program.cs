Console.WriteLine("Программа выводящая все натуральные числа в промежутке от 1 до N через рекурсию");

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



void Sequence(int n)
{
    if (n<1) return;
    if (n>1)
    {
       Sequence(n-1); 
    }
    if (n==1)
    {
       Console.Write($"{n}"); 
    }
    else
    {
        Console.Write($", {n}");
    }
}


Console.WriteLine("Введите количество элементов последовательности (N): ");
int number = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Sequence(number);