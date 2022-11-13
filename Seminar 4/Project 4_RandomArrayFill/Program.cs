Console.WriteLine("Программа заполнения массива числами 0,1 в случайном порядке");
Console.WriteLine("Введите целое число (размерность массива): ");
int number;

while ((!int.TryParse(Console.ReadLine()!, out number)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение в numA 
{

    Console.WriteLine("Неверный ввод. Введите целое число");
    Console.WriteLine("Введите число заново: ");
}

int[] ArrayFilling(int number) // функция заполняет массив случайно сгенеррированным числом от 0 до 1
{
    int[] SomeArray = new int[number];
    int i = 0;
    Random randomNumber = new Random(); // генерируем рандомное число за пределами цикла для экономии памяти
    while (i < SomeArray.Length)
    {
        SomeArray[i] =  randomNumber.Next(0,2); // заполняем массив по одной цифре нулем или единицей. Генерируем случайно
        i++;
    }
    return SomeArray;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
        number++;
    }
    
}

int[] PrimaryArray = ArrayFilling(number); //заполним массив
PrintArray(PrimaryArray); // напечатаем массив

