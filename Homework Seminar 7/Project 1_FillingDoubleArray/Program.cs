// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Программа заполнения массива случайными вещественными числами");

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

void PrintArray2D(double[,] matr)
{
    Random random = new();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
           // Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            Console.Write(String.Format("{0,-8}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
            //Console.ResetColor();
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}

double[,] FillArray(int n, int m)
{
    double[,] someArray = new double[n, m];
    Random random = new();
    for (int rows = 0; rows < n; rows++)
    {
        for (int columns = 0; columns < m; columns++)
        {

            someArray[rows, columns] = Math.Round((random.NextDouble() + random.Next(0,100)),2);

        }

    }
    return someArray;
}

Console.WriteLine("Введите количество строк массива: ");
int rowsOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите количество столбцов массива: ");
int colOfArray = InputCheck(); // введем число и проверим ввод

double[,] resultArray = FillArray(rowsOfArray, colOfArray);
PrintArray2D(resultArray);
