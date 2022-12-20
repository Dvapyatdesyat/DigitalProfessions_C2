Console.WriteLine("Программа перемешивающая массив");

// функция проверки ввода ряда чисел через запятую
static int[] InputCheckString()
{
    Console.WriteLine("");
NewInput:
    Console.Write("Введите размерность массива через запятую (количество элементов должно быть четным, введите не более двух чисел): ");
    string input = Console.ReadLine()!; //переменная для ввода значений из консоли
    string[] inputStringArray = input.Split(','); //.Split делит строку на массив с заданным в скобках разделителем
    if (inputStringArray.Length != 2)
    {
        Console.WriteLine($"err: некорректный ввод!");
        goto NewInput; // переходим к метке NewInput
    }
    int[] result = new int[inputStringArray.Length]; //задаем результирующий массив с длинной на основании результата выполнения метода Split

    for (int i = 0; i < inputStringArray.Length; i++)
    {
        string tempStr = inputStringArray[i].Trim(); // убираем боковые пробелы

        if (int.TryParse(tempStr, out int tempInt)) // если элемент - число
        {
            result[i] = tempInt; // запись элемента в результирующий массив
        }

        else  // если если элемент - НЕ число
        {
            Console.WriteLine($"err: некорректный ввод!");
            goto NewInput; // переходим к метке NewInput
        }
    }

    if (result[0] == 0 || result[1] == 0)
    {
        if ((result[0] % 2 != 0 || result[1] % 2 != 0))
        {
            Console.WriteLine($"err: некорректный ввод!");
            goto NewInput; // переходим к метке NewInput 
        }
    }
    return result;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if (i != array.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }

// }

// метод печати двумерного массива
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


int[,] AdvancedFillArray(int n, int m) //метод заполняющий массив случайными уникальными числами
{
    int[,] someArray = new int[n, m];
    Random random = new();
    someArray[n - 1, m - 1] = random.Next(1, 20);
    int temp = someArray[n - 1, m - 1];
    for (int rows = n - 1; rows >= 0; rows--)
    {

        for (int columns = m - 1; columns >= 0; columns--)
        {

        Random:
            int temp2 = random.Next(1, 20);
           
            if (temp2 == temp)
            {
                goto Random;
            }
            else
            {
                someArray[rows, columns] = temp2;
            }
            temp = someArray[rows, columns];
        }

    }
    return someArray;
}


//метод перемешивающий массив за m*n / 2 итераций с гарантированным перемещением каждого элемента
int[,] ArrayMixer(int[,] array)
{

    Random random = new();
    for (int i = array.GetLength(0) - 1; i >= 1; i--)
    {
        for (int j = array.GetLength(1) - 1; j >= 1; j--)
        {
            int randomI = random.Next(i + 1);
            int randomJ = random.Next(j + 1);
            // обменять значения array[j] и array[i]
            var temp = array[randomI, randomJ];
            array[randomI, randomJ] = array[i, j];
            array[i, j] = temp;
        }
    }


    return array;

}



int[] inputArray = InputCheckString(); // введем размерность массива через запятую
Console.WriteLine(" ");
//PrintArray(inputArray);
int[,] primaryArray = AdvancedFillArray(inputArray[0], inputArray[1]);
PrintArray2D(primaryArray);
Console.WriteLine(" ");
int[,] secondaryArray = ArrayMixer(primaryArray);
PrintArray2D(secondaryArray);