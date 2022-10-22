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
int[] ArrayFilling(int N)
{
    int[] SomeArray = new int[N];
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = new Random().Next(-100, 100);
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

Console.WriteLine("Введите размерность пространства N: ");
int N = InputCheck(); // введем число N и проверим ввод


int[] FirstPointArray = ArrayFilling(N); //заполняем массив координат для первой точки с помощью функции заполнения
PrintArray(FirstPointArray); // распечатаем результат ввода
Console.WriteLine(""); // пустая строка для переноса в консоли. Форматирование вывода

int[] SecondPointArray = ArrayFilling(N);
PrintArray(SecondPointArray);

int[] TempArray = new int[N];
int tempResult = 0;
for (int i = 0; i < TempArray.Length; i++)
{
    TempArray[i] = Convert.ToInt32(Math.Pow((FirstPointArray[i] - SecondPointArray[i]), 2));
    tempResult = tempResult + TempArray[i];
}

double result = Math.Sqrt(tempResult);
Console.WriteLine("");
Console.WriteLine("Расстояние между двумя точками: " + result);