// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

Console.WriteLine("Программа мультифункционального анализа элементов массива");

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

// функция поиска максимального элемента массива
int MaxNumberFinder(int[] Array)
{
    int max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }
    }
    return max;
}

// функция поиска индекса максимального элемента массива
int MaxNumberIndexFinder(int[] Array)
{
    int maxIndex = 0;
    int max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            maxIndex = i;
        }
    }
    return maxIndex;
}

// функция поиска минимального элемента массива
int MinNumberFinder(int[] Array)
{
    int min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    return min;
}

// функция поиска индекса минимального элемента массива
int MinNumberIndexFinder(int[] Array)
{
    int minIndex = 0;
    int min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
        {
            minIndex = i;
        }
    }
    return minIndex;
}

// функция нахождения среднего арифтметического элементов массива
int ArithmeticMean(int[] Array)
{
    int arMean = 0;
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        sum = sum + Array[i];
    }
    return arMean = sum / Array.Length;
}

// функция упаковки результата в новый массив
int[] ArrayFiller(int max, int maxIndex, int min, int minIndex, int arMean)
{
    int[] SomeArray = new int[5];
    SomeArray[0] = max;
    SomeArray[1] = maxIndex;
    SomeArray[2] = min;
    SomeArray[3] = minIndex;
    SomeArray[4] = arMean;
    return SomeArray;
}

// функция сортировки массива
int[] ArraySorter(int[] array)
{
for (int i = 0; i < array.Length; i++)
{

    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
            
        }
    }
}
    return array;
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

// функция печати двух массивов
void PrintArrayDouble(string[] tArray, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{tArray[i]}{array[i]}");
        // if (i != array.Length - 1)
        // {
        //     Console.Write(", ");
        // }
    }

}

Console.WriteLine("Введите размерность массива: ");
int lenghtOfArray = InputCheck(); // введем число lenghtOfArray и проверим ввод
int[] selfMadeArray = CreateArrayWithRandomNumbers(lenghtOfArray); // заполним массив соответствующим методом. Аргументы не указываем
PrintArray(selfMadeArray); // напечатаем исходный массив
Console.WriteLine(" ");
int max = MaxNumberFinder(selfMadeArray);
int maxIndex = MaxNumberIndexFinder(selfMadeArray);
int min = MinNumberFinder(selfMadeArray);
int minIndex = MinNumberIndexFinder(selfMadeArray);
int arMean = ArithmeticMean(selfMadeArray);
int[] digitArray = ArrayFiller(max, maxIndex, min, minIndex, arMean);

string[] textArray = new string[5];
textArray[0] = $"Максимальный элемент: ";
textArray[1] = $"Индекс максимального элемента: ";
textArray[2] = $"Минимальный элемент: ";
textArray[3] = $"Индекс минимального элемента: ";
textArray[4] = $"Среднее арифметическое элементов массива: ";

PrintArrayDouble(textArray, digitArray);
Console.WriteLine(" ");

Console.WriteLine("отсортированный массив: ");
int[] sortedArray = ArraySorter(selfMadeArray);
PrintArray(sortedArray);
Console.WriteLine(" ");
int median = sortedArray.Length % 2;
if (median != 0)
{
    Console.WriteLine($"Медианное значение: {sortedArray[(sortedArray.Length / 2)]}");
}
else
{
    double m = (sortedArray[(sortedArray.Length / 2)-1] + sortedArray[(sortedArray.Length / 2) ]) / 2;
    Console.WriteLine($"Медианное значение: {m}");
}