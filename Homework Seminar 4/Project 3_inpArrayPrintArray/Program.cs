// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Программа для заполнения массива с клавиатуры и последующего вывода его в консоль");

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

// функция заполнения массива
int[] ArrayFilling(int N)
{
    int[] SomeArray = new int[N];

    for (int i = 0; i < SomeArray.Length; i++)
    {
        Console.WriteLine($"введите {i}-й элемент массива: ");
        SomeArray[i] = InputCheck();

    }
    return SomeArray;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }

}

Console.WriteLine("Введите размерность массива (N): ");
int N = InputCheck(); // введем число N и проверим ввод
int[] ResultArray = ArrayFilling(N); // заполним массив соответствующим методом
PrintArray(ResultArray); // напечатаем массив