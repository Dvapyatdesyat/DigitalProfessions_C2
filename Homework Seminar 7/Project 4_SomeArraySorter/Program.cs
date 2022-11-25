Console.WriteLine("Программа по сортировке массива по возрастанию");

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

void PrintArray2D(int[,] matr)
{

    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write(String.Format("{0,-4}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
        }
        Console.WriteLine();
    }
}


int[,] FillArray(int n, int m)
{
    int[,] someArray = new int[n, m];
    Random random = new();
    for (int rows = 0; rows < n; rows++)
    {
        for (int columns = 0; columns < m; columns++)
        {
            someArray[rows, columns] = random.Next(1, 10);
        }

    }
    return someArray;
}

// функция поиска минимального элемента двумерного массива 
int MinNumberFinder2D(int[,] Array)
{
    int min = Array[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] <= min)
            {
                min = Array[i, j];

            }
        }
    }
    return min;
}

// функция поиска индекса минимального элемента двумерного массива
int[] MinNumberIndexFinder2D(int[,] Array)
{
    int[] minIndexArray = new int[2];
    int min = Array[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {

            if (Array[i, j] <= min)
            {
                min = Array[i, j];
                minIndexArray[0] = i;
                minIndexArray[1] = j;

            }
        }
    }
    return minIndexArray;
}

//метод сортировки массива по возрастанию
int[,] ArraySorterInOrder(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    int minNumber = resultArray[0, 0];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minNumber = MinNumberFinder2D(array); 
            int[] minNumberIndex = MinNumberIndexFinder2D(array); 
            array[minNumberIndex[0], minNumberIndex[1]] = Int32.MaxValue; 
            resultArray[i, j] = minNumber; 
            
        }

    }

    return resultArray;

}

Console.WriteLine("Введите количество строк массива: ");
int rowsOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите количество столбцов массива: ");
int colOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
int[,] primaryArray = FillArray(rowsOfArray, colOfArray);
PrintArray2D(primaryArray);
Console.WriteLine(" ");
int[,] seconadaryArray = ArraySorterInOrder(primaryArray);
PrintArray2D(seconadaryArray);