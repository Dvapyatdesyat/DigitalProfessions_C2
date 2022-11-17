Console.WriteLine("Программа для подсчета четных элементов массива");

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

// функция заполнения массива случайными числами
int[] CreateArrayWithRandomNumbers(int lenghtOfArray, int startInterval = -1000, int endInterval = 1000) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    int[] SomeArray = new int[lenghtOfArray];
    Random random = new();
    for (int i = 0; i < lenghtOfArray; i++)
    {
        SomeArray[i] = random.Next(startInterval, endInterval);
    }
    return SomeArray;
}

// функция считающая сумму элементов массива стоящих на нечетных позициях
int OddItemsSummator(int[] Array)
{
    int sum = 0;
    for (int i = 1; i < Array.Length; i = i + 2)
    {

        sum = sum + Array[i];

    }
    return sum;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }

}

Console.WriteLine("Введите размерность массива: ");
int lenghtOfArray = InputCheck(); // введем число lenghtOfArray и проверим ввод
int[] selfMadeArray = CreateArrayWithRandomNumbers(lenghtOfArray); // заполним массив соответствующим методом. Аргументы не указываем
PrintArray(selfMadeArray); // напечатаем массив
Console.WriteLine(" ");
Console.WriteLine($"Сумма нечетных элементов массива: {OddItemsSummator(selfMadeArray)}");