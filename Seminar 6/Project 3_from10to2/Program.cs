Console.WriteLine("Программа перевода числа из 10й системы счисления в 2ую");

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

// функция сортировки массива из трех элементов, заполненного введенными с консоли значениями
string From10to2(int number)
{
    // int digitCount = 0;
    // while (number > 0)
    // {
    //     number = number / 10;
    //     digitCount++;
    // }
    // int[] array = new int[digitCount] ;
    string temp = " ";
    while (number >= 1)
    {

        temp = temp + Convert.ToString(number % 2);
        number = number / 2;
    }

string reversString="";
    for (int i = 0; i < temp.Length; i++)
    {
        reversString = reversString + Convert.ToString(temp[temp.Length - i - 1 ]);

    }
    return reversString;
}


Console.WriteLine($"Введите число для перевода: ");
int inputNumber = InputCheck();

string result = From10to2(inputNumber);

Console.WriteLine($"результат перевода: {result} ");
