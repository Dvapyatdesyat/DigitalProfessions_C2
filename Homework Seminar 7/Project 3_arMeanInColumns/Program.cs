// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Программа поиска среднего арифметического по столбцам");

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
    Random random = new();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write(String.Format("{0,-4}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
        }
        Console.WriteLine();
    }
}

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

//метод нахождения среднего арифметического в столбцах массива
double[] FindArMeanByColumns(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    int sum = 0;
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sum = sum + array[rows, columns];
        }
        resultArray[columns] = (double)sum / array.GetLength(0); // (double)  - для деления с остатком
        sum = 0; // сбросим счетчик суммы
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

double[] resultArray = FindArMeanByColumns(primaryArray);
Console.WriteLine("Среднее арифметические по столбцам: ");
PrintArray(resultArray);
