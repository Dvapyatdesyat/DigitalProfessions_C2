Console.WriteLine("Программа для поиска заданного элемента в массиве");

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

// функция поиска элемента массива
bool ArrayItemFinder(int[] Array, int searcheableNumber)
{
bool result = false;
    for (int i = 0; i < Array.Length; i++)
    {

       if (Array[i] ==  searcheableNumber)
       {
        result = true;
        break;
       }

    }
    return result;
}
// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{

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
Console.Write($"Введенный массив: ");
PrintArray(SomeArray); // напечатаем массив

Console.WriteLine(" ");
Console.WriteLine("Введите искомое число: ");
int searcheableNumber = InputCheck(); // введем число N и проверим ввод
Console.WriteLine(" ");
Console.WriteLine($"Искомое число есть в массиве: {ArrayItemFinder(SomeArray, searcheableNumber)}");
