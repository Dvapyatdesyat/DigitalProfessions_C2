Console.WriteLine("программа-решение домашнего задания");
// попросим пользователя ввести номер задачи
Found:
Console.WriteLine("Введите номер задачи (от 1 до 4): ");
int number = int.Parse(Console.ReadLine()!);

//проверим корреткность ввода

if (number < 1 || number > 4)
{
    Console.WriteLine("ALARM!!! Введен неправильный номер задачи.");
    goto Found; // Переходим к вводу по тегу Found
}
else
{
    if (number == 1) // Проверяем ввод. Выполняем соответствующую задачу
    {
        Console.WriteLine("Программа для решения задачи №1:");
        Console.WriteLine("Введите Число №1");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите Число №2");
        int number2 = int.Parse(Console.ReadLine()!);
        int min = number1;
        int max = number2;

        if (number1 > number2)
        {
            Console.WriteLine("Число №1: " + number1);
            Console.WriteLine("Число №2: " + number2);
            Console.WriteLine("MAX=" + number1);
            Console.WriteLine("MIN=" + number2);
        }
        else
        {
            Console.WriteLine("Число №1: " + number1);
            Console.WriteLine("Число №2: " + number2);
            Console.WriteLine("MAX=" + number2);
            Console.WriteLine("MIN=" + number1);
        }
    }
    if (number == 2) // Проверяем ввод. Выполняем соответствующую задачу
    {
        Console.WriteLine("Программа для решения задачи №2:");
        int[] array = new int[3]; // обяъвили массив из 3 элементов
        int max = array[1];
        // заполним массив с клавиатуры
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите {0}-й элемент", i + 1);
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine("MAX= " + max);
    }
    if (number == 3) // Проверяем ввод. Выполняем соответствующую задачу
    {
        Console.WriteLine("Программа для решения задачи №3:");
        Console.WriteLine("Введите Число: ");
        int digit = int.Parse(Console.ReadLine()!);

        if (digit % 2 == 0) // проверяем есть ли остаток от деления на 2. Если нет - число четное
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
    }
    if (number == 4) // Проверяем ввод. Выполняем соответствующую задачу
    {
        Console.WriteLine("Программа для решения задачи №4:");
    Found2:
        Console.WriteLine("Введите размерность массива (Положительное целое число): ");
        var digit4 = int.Parse(Console.ReadLine()!); //переменная для задачи №4
        if (digit4 < 1)
        {
            Console.WriteLine("ALARM!!! Введена неправильное значение");
            goto Found2; // Переходим к вводу по тегу Found2
        }
        else
        {
            Console.WriteLine("Искомый массив: ");
            for (int i = 2; i < digit4 + 2; i = i + 2)
            {

                Console.Write(i + ","+" ");
            }

        }
    }
}
