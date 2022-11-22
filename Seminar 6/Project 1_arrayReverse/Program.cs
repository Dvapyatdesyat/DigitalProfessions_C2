//задача на разворот массива

// функция заполнения массива случайными числами
int[] CreateArrayWithRandomNumbers(int lenghtOfArray) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    int[] SomeArray = new int[lenghtOfArray];
    Random random = new();
    for (int i = 0; i < lenghtOfArray; i++)
    {
        SomeArray[i] = random.Next (0,100);

    }
    return SomeArray;
}

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

// функция разворота массива
int[] ReverseArray(int [] array) 
{
    int[] SomeArray = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        SomeArray[i] = array[array.Length - i - 1];

    }
    return SomeArray;
}

Console.WriteLine("Введите размерность массива: ");
int lenghtOfArray = InputCheck(); // введем число lenghtOfArray и проверим ввод
int[] selfMadeArray = CreateArrayWithRandomNumbers(lenghtOfArray); // заполним массив соответствующим методом. Аргументы не указываем
PrintArray(selfMadeArray); // напечатаем массив
Console.WriteLine(" ");
int [] resulArray = ReverseArray (selfMadeArray);
PrintArray(resulArray); // напечатаем массив
Console.WriteLine(" ");

