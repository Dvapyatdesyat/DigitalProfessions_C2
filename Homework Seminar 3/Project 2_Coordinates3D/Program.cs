Console.WriteLine("Программа вычисления длины отрезка в трехмерном пространстве");
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
// функция заполнения массива
int[] ArrayFilling()
{
    int[] SomeArray = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Введите x{i + 1}: ");
        SomeArray[i] = InputCheck();
    }
    return SomeArray;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{
    Console.Write("Введенные координаты точки: (");
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"x{number}:{Array[i]} ");
        number++;
    }
    Console.Write(")");
}

Console.WriteLine("Введите координаты первой точки: ");
int[] FirstPointArray = ArrayFilling(); //заполняем массив координат для первой точки с помощью функции заполнения
PrintArray(FirstPointArray); // распечатаем результат ввода
Console.WriteLine(""); // пустая строка для переноса в консоли. Форматирование вывода
Console.WriteLine("Введите координаты второй точки: ");
int[] SecondPointArray = ArrayFilling();
PrintArray(SecondPointArray);

double result = Math.Sqrt(Math.Pow((FirstPointArray[0] - SecondPointArray[0]), 2) + Math.Pow((FirstPointArray[1] - SecondPointArray[1]), 2) + Math.Pow((FirstPointArray[2] - SecondPointArray[2]), 2));
Console.WriteLine("");
Console.WriteLine("Расстояние между двумя точками: " + result);