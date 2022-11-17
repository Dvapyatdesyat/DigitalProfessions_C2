Console.WriteLine("Программа для поиска минимума и максимума в массиве вещественных чисел");

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
double[] CreateArrayWithRandomNumbers(int lenghtOfArray) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    double[] SomeArray = new double[lenghtOfArray];
    Random random = new();
    for (int i = 0; i < lenghtOfArray; i++)
    {
        SomeArray[i] = random.Next (-200,200) + random.NextDouble();

    }
    return SomeArray;
}

// функция находит минимальный элемент массива
double MinFinder(double[] Array)
{
 
   double minItem = Array[0];
    
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]<minItem)
        {
            minItem = Array[i];
        }
 
    }
    return minItem;
}

// функция находит минимальный элемент массива
double MaxFinder(double[] Array)
{
 
   double maxItem = Array[0];
    
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]>maxItem)
        {
            maxItem = Array[i];
        }
 
    }
    return maxItem;
}
// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(double[] array)
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
double[] selfMadeArray = CreateArrayWithRandomNumbers(lenghtOfArray); // заполним массив соответствующим методом. Аргументы не указываем
PrintArray(selfMadeArray); // напечатаем массив
Console.WriteLine(" ");
double min = MinFinder(selfMadeArray);
double max = MaxFinder(selfMadeArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max} - {min} =  {max-min}");