Console.WriteLine("Программа подсчета количества положительных чисел в введенной пользователем строке");
// // Функция ввода и проверки массива целых чисел.
// static int[] InputArrayNumbers()
// {

//     Console.WriteLine("");

// NewInput:

//     Console.Write("Введите числа: ");

//     string str = Console.ReadLine()!;

//     string[] str_ = str.Split(','); // разбив на элементы

//     int[] rezult = new int[str_.Length];
//     for (int i = 0; i < str_.Length; i++)
//     {
//         string tempStr = str_[i].Trim(); // долой боковые пробелы

//         if (int.TryParse(tempStr, out int tempInt)) // если элемент - число
//         {
//             rezult[i] = tempInt; // запись элемента
//         }
//         else // если если элемент - НЕ число
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine($"err: некорректный ввод {i + 1}-го элемента!");
//             Console.ResetColor();

//             goto NewInput; // поехали сначала
//         }

//     }

//     return rezult;
// }

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

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
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

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
int PosArrayAnalizator(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] selfMadeArray = InputCheckString();
PrintArray(selfMadeArray);
Console.WriteLine(" ");
Console.Write($"Количество положительных чисел в введенном ряду: {PosArrayAnalizator(selfMadeArray)}");
