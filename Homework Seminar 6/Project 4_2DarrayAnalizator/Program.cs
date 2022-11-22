// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
//  Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс, среднее арифметическое. Вывести эту информацию на экран.

Console.WriteLine("Программа мультифункционального анализа элементов двумерного массива");

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
            //Console.Write($"{matr[rows, columns]} ");
            Console.Write(String.Format("{0,-4}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
            
        }
        Console.WriteLine();
    }
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

int[,] FillArray(int n, int m)
{
    int[,] someArray = new int[n, m];
    for (int rows = 0; rows < n; rows++)
    {
        for (int columns = 0; columns < m; columns++)
        {
            someArray[rows, columns] = new Random().Next(1, 200);
        }

    }
    return someArray;
}

// функция поиска максимального элемента двумерного массива
int MaxNumberFinder2D(int[,] Array)
{
    int max = Array[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] >= max)
            {
                max = Array[i, j];
            }
        }
    }
    return max;
}

// функция поиска индекса максимального элемента двумерного массива
int[] MaxNumberIndexFinder2D(int[,] Array)
{
    int[] maxIndexArray = new int[2];
    int max = Array[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] >= max)
            {
                max = Array[i, j];
                maxIndexArray[0] = i;
                maxIndexArray[1] = j;

            }
        }
    }
    return maxIndexArray;
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

// функция нахождения среднего арифтметического элементов двумерного массива
double ArithmeticMean2D(int[,] Array)
{
    double arMean = 0;
    double sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)

        {
            sum = sum + Array[i, j];
        }
    }
    return arMean = sum / (Array.GetLength(0) * Array.GetLength(1));
}

Console.WriteLine("Введите количество строк массива: ");
int rowsOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите количество столбцов массива: ");
int colOfArray = InputCheck(); // введем число и проверим ввод

int[,] resultArray = FillArray(rowsOfArray, colOfArray);
PrintArray2D(resultArray);

Console.WriteLine(" ");
int max = MaxNumberFinder2D(resultArray);
Console.WriteLine($"Максимальное значение: {max}");
Console.Write($"Индекс элемента с максимальным значением: ");
int[] maxIndex = MaxNumberIndexFinder2D(resultArray);
PrintArray(maxIndex);
Console.WriteLine(" ");
int min = MinNumberFinder2D(resultArray);
Console.WriteLine($"Минимальное значение: {min}");
Console.Write($"Индекс элемента с минимальным значением: ");
int[] minIndex = MinNumberIndexFinder2D(resultArray);
PrintArray(minIndex);
Console.WriteLine(" ");
double arMean = ArithmeticMean2D(resultArray);
Console.WriteLine($"Среднее арифмитическое элементов массива: {arMean}");