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
int[] CreateArrayWithRandomNumbers(int lenghtOfArray, int startInterval = 100, int endInterval = 1000) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    int[] SomeArray = new int[lenghtOfArray];
    Random random = new();
    for (int i = 0; i < lenghtOfArray; i++)
    {
        SomeArray[i] = random.Next(startInterval, endInterval);
    }
    return SomeArray;
}

// функция считающая количество четных элементов массива
int EvenNumbersCounter(int[] Array)
{
    int counter = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]%2 == 0)
        {
            counter++;
        }
    }
    return counter;
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
Console.WriteLine($"Количество четных элементов массива: {EvenNumbersCounter(selfMadeArray)}");