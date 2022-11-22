Console.WriteLine("Программа вывода первых N чисел Фибоначчи");

// функция проверки ввода
int InputCheck()
{
    int inputValue;


    while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    
    {

        Console.WriteLine("Неверный ввод. Введите целое число больше 1");
        Console.WriteLine("Введите число заново: ");
    }
while (inputValue<2) 
{
    Console.WriteLine("Неверный ввод. Введите целое число больше 1");
     while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    
    {

        Console.WriteLine("Неверный ввод. Введите целое число больше 1");
        Console.WriteLine("Введите число заново: ");
    }
}
    return inputValue;
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


// функция заполнения массива числами фибоначчи
int[] FibonacciArray(int number)
{

    int[] SomeArray = new int[number];
    if (number <= 2)
    {
        SomeArray[0] = 0;
        SomeArray[1] = 1;
        return SomeArray;
    }
    else
    {
        SomeArray[0] = 0;
        SomeArray[1] = 1;
        SomeArray[2] = 1;

        for (int i = 2; i < number; i++)

        {
            SomeArray[i] = SomeArray[i - 1] + SomeArray[i - 2];
        }

        return SomeArray;
    }
}

Console.WriteLine($"Введите число : ");
int number = InputCheck();

int[] selfMadeArray = FibonacciArray(number); // заполним массив соответствующим методом. Аргументы не указываем
PrintArray(selfMadeArray); // напечатаем исходный массив

