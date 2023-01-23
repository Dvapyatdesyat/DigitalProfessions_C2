﻿//Метод ввода и проверки ввода числа-размерности массива
int InputCheck()
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue))) //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение
    {
        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

//Метод заполнения массива
string[] FillArray(int n)
{
    string[] someArray = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        someArray[i] = Console.ReadLine()!;
    }
    return someArray;
}

//Метод печати массива

void PrintArray(string[] array)
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

//Метод подсчета элементов массива которые содержат меньше 3 символов
int Array3AndLessCounter(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

//Метод заполнения результирующего массива

//Тело программы
Console.WriteLine(
    "Программа для заполнения и вывода массива составленного из исходного путем выбора элементов с длинной меньшей или равной трем"
);
Console.WriteLine("Введите количество элементов массива: ");
int SomeArrayLenth = InputCheck(); // введем число и проверим ввод
Console.WriteLine(" ");
string[] primaryArray = FillArray(SomeArrayLenth);
Console.WriteLine("Введенный массив: ");
PrintArray(primaryArray);
Console.WriteLine(" ");
int count = Array3AndLessCounter(primaryArray);
Console.WriteLine(count);

//Console.WriteLine("Полученный массив: ");
//PrintArray(resultArray);
// Console.WriteLine(" ");
// int[,] seconadaryArray = ArraySorterInOrder(primaryArray);
// PrintArray2D(seconadaryArray);
