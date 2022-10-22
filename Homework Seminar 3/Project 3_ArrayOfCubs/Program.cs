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
    int count=1;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] = Convert.ToInt32 (Math.Pow((count), 3)); count++;
    }
    return SomeArray;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
        number++;
    }
    
}

Console.WriteLine("Введите N: ");
int N = InputCheck();
int[] CubsArray = ArrayFilling(N); 
PrintArray(CubsArray);