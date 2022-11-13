// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

Console.WriteLine("Программа анализатор массива на количество 0 и 1");

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
int[] RandomArrayFilling(int N)
{
    int[] SomeArray = new int[N];
    Random randomNumber = new Random(); // генерируем рандомное число за пределами цикла для экономии памяти
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = randomNumber.Next(0, 2); // заполняем массив по одной цифре нулем или единицей. Генерируем случайно

    }
    return SomeArray;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }

}

// метод анализа массива
bool ArrayAnalizator(int[] Array)
{
    int count0 = 0;
    int count1 = 0;
    bool res = false;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == 0)
        {
            count0 = count0 + 1;
        }
        else
        {
            count1 = count1 + 1;
        }
    }
    Console.WriteLine($"count0: {count0} ");
    Console.WriteLine($"count1: {count1} ");
    if (count1 > count0)
    {
        res = true;
    }
    return res;
}

Console.WriteLine("Введите размерность массива (N): ");
int N = InputCheck(); // введем число N и проверим ввод
int[] ResultArray = RandomArrayFilling(N); // заполним массив соответствующим методом
Console.WriteLine("Сгенерированный массив: ");
PrintArray(ResultArray); // напечатаем массив
Console.WriteLine("");
Console.WriteLine($"Результат анализа массива. В массиве единиц больше, чем нулей: {ArrayAnalizator(ResultArray)}");