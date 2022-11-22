Console.WriteLine("Программа проверки возможности существования треугольника с заданными сторонами");

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


// функция решения задачи о треугольнике
bool Triangle(int a, int b, int c)
{
    bool result = false;
    if (a < b + c && b < a + c && c < a + b) result = true;
    return result;
}

Console.WriteLine($"Введите число 1: ");
int side1 = InputCheck();
Console.WriteLine($"Введите число 2: ");
int side2 = InputCheck();
Console.WriteLine($"Введите число 3: ");
int side3 = InputCheck();

bool result = Triangle(side1, side2, side3);
Console.WriteLine($"треугольник с заданными длинами сторон существует: {result} ");
