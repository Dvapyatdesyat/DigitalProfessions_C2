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
        Console.Clear(); // очищаем консоль от лишней информации
        Console.WriteLine("Программа для решения задачи №1:");
        if (number1 > number2)
        {
            Console.WriteLine("MAX=" + number1);
            Console.WriteLine("MIN=" + number2);
        }
        else
        {
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
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8