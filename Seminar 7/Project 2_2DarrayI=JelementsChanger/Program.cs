Console.WriteLine("Программа замены элементов с двумя четными индексами на их квадраты и сумму элементов главно диагонали");

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
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            Console.Write(String.Format("{0,-4}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
            Console.ResetColor();
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
            if (rows % 2 == 0 && columns % 2 == 0)
            {
                someArray[rows, columns] = Convert.ToInt32(Math.Pow(random.Next(1, 10), 2));
            }
            else
            {
                someArray[rows, columns] = random.Next(1, 10);
            }
        }

    }
    return someArray;
}

//метод поиска суммы элементов на главно диагонали
void SumElementsOfMainDiag(int[,] matr)
{
    int sum = 0;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            if (columns == rows)
            {
                sum = sum + matr[rows, columns];
            }
        }
        Console.WriteLine();
        
    }
    Console.WriteLine($"сумма элементов главной диагонали: {sum}");
}


Console.WriteLine("Введите количество строк массива: ");
int rowsOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите количество столбцов массива: ");
int colOfArray = InputCheck(); // введем число и проверим ввод

int[,] resultArray = FillArray(rowsOfArray, colOfArray);
PrintArray2D(resultArray);
Console.WriteLine(" ");
SumElementsOfMainDiag(resultArray);