Console.WriteLine("Программа возведения подсчета суммы цифр в числе");

int InputCheck() //метод проверки ввода
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    {

        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

int SumOfDigits(int A) // метод подсчета суммы цифр
{
    
    int result = 0;

    do
    {
        result = result + A % 10;
        A=A/10;
        
    }
    while (A > 0);

    return result;
}

Console.WriteLine("Введите целое число: ");
int A = InputCheck(); // введем число A и проверим ввод

Console.Write($"Результат: {SumOfDigits(A)}");
