Console.WriteLine("Программа для подсчета произведений пар элементов в массиве");

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
int[] CreateArrayWithRandomNumbers(int lenghtOfArray, int startInterval = 0, int endInterval = 10) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    int[] SomeArray = new int[lenghtOfArray];
    Random random = new();
    for (int i = 0; i < lenghtOfArray; i++)
    {
        SomeArray[i] = random.Next(startInterval, endInterval + 1);

    }
    return SomeArray;
}

// функция считает произведение пар и записывает их в новый массив
int[] CompOfPairs(int[] Array)
{
 
    int[] ResultArray = new int[Array.Length/2];
    
   int n = Array.Length / 2;
    for (int i = 0; i < n; i++)
    {
        ResultArray[i] = Array[i] * Array[Array.Length-i-1];
 
    }
    return ResultArray;
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
int[] resultArray = CompOfPairs(selfMadeArray);
PrintArray(resultArray); // напечатаем массив