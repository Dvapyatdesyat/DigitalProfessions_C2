Console.WriteLine("Программа возводящая M в степень N через рекурсию");

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

int Degree (int a, int b)
{
    if (b>0) return a* Degree(a, b-1);
    else if (b==0) return 1;
    else return 1/ (a* Degree (a, -b-1));
}


Console.WriteLine("Введите возводимое число (N): ");
int number = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Console.WriteLine("Введите степень (M): ");
int numberM = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
Console.WriteLine($"{number}^{numberM} = " + Degree(number,numberM));
