Console.WriteLine("Программа для замены знака у элементов массива и последующего вывода его в консоль");

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
        Console.WriteLine($"введите {i}-й элемент массива: ");
        SomeArray[i] = InputCheck();

    }
    return SomeArray;
}

// функция cсмены знака у элементов массива
int[] ArraySignInversion(int[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {

        Array[i] = Array[i] * (-1);

    }
    return Array;
}
// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{
Console.Write($"Результирующий массив: ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}");
        if (i != Array.Length - 1)
        {
            Console.Write(", ");
        }
    }

}



Console.WriteLine("Введите размерность массива (N): ");
int N = InputCheck(); // введем число N и проверим ввод
int[] SomeArray = ArrayFilling(N); // заполним массив соответствующим методом
int[] ResultArray = ArraySignInversion(SomeArray);
PrintArray(ResultArray); // напечатаем массив