// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Программа поиска элемента в массиве по заданным идексам");

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

// функция проверки ввода ряда чисел через запятую
static int[] InputCheckString()
{
    Console.WriteLine("");
NewInput:
    Console.Write("Введите число и текст через запятую: ");
    string input = Console.ReadLine()!; //переменная для ввода значений из консоли
    string[] inputStringArray = input.Split(','); //.Split делит строку на массив с заданным в скобках разделителем
    int[] result = new int[inputStringArray.Length]; //задаем результирующий массив с длинной на основании результата выполнения метода Split

    for (int i = 0; i < inputStringArray.Length; i++)
    {
        string tempStr = inputStringArray[i].Trim(); // убираем боковые пробелы

        if (int.TryParse(tempStr, out int tempInt)) // если элемент - число
        {
            result[i] = tempInt; // запись элемента в результирующий массив
        }
        else // если если элемент - НЕ число
        {

            Console.WriteLine($"err: некорректный ввод {i + 1}-го элемента!");

            goto NewInput; // переходим к метке NewInput
        }

    }
    return result;
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

void PrintArray2Dindicator(int[,] matr, int[] inputIndexes)
{
    Random random = new();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            if (rows == inputIndexes[0] && columns == inputIndexes[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(String.Format("{0,-4}", matr[rows, columns])); //String.Format форматирует строку. {0,-4} определяет 4-символьного поля, выравниваемая по левому краю, без "-" по правому
                Console.ResetColor();
            }
            else
            {
                Console.Write(String.Format("{0,-4}", matr[rows, columns]));
            }
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

//метод поиска элемента в массиве по заданным идексам
int FindElementByIndexes(int[,] matr, int[] inputIndexes)
{
    if (inputIndexes[0] > matr.GetLength(0) || inputIndexes[1] > matr.GetLength(1))
    {
        return Int32.MinValue;
    }
    else
    {
        return matr[inputIndexes[0], inputIndexes[1]];
    }
}


Console.WriteLine("Введите количество строк массива: ");
int rowsOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите количество столбцов массива: ");
int colOfArray = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
int[,] resultArray = FillArray(rowsOfArray, colOfArray);
PrintArray2D(resultArray);

int[] selfMadeArray = InputCheckString(); // введем индексы  искомого элемента массива
Console.WriteLine(" ");
PrintArray2Dindicator(resultArray, selfMadeArray);
Console.WriteLine(" ");
int result = FindElementByIndexes(resultArray, selfMadeArray);
if (result == Int32.MinValue)
{
    Console.WriteLine($"В массиве отсутствует элемент с индексами {selfMadeArray[0]},{selfMadeArray[1]}");
}
else
{
    Console.WriteLine($"Запрошенный элемент с индексами {selfMadeArray[0]},{selfMadeArray[1]}: {result}");
}