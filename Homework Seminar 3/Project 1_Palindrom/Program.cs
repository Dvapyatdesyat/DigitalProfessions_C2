// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа проверки числа на принадлежность к палиндромам");
Console.WriteLine("Введите целое число: ");
int number;

while ((!int.TryParse(Console.ReadLine()!, out number)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение в numA 
{

    Console.WriteLine("Неверный ввод. Введите целое число");
    Console.WriteLine("Введите число заново: ");
}

int[] ArrayFilling(int number) // функция заполняет массив на основе введенного number путем поразрядного деления числа
{
    int n = Convert.ToInt32(Math.Log10(number) + 1); // узнаем длину числа
    int[] SomeArray = new int[n];
    int count = 1;
    int i = 0;
    while (i < SomeArray.Length)
    {
        SomeArray[i] = number / count % 10; // заполняем массив по одной цифре
        i++;
        count = count * 10;
    }
    return SomeArray;

}
int[] GetSecondaryArray(int[] PrimaryArray) //функция разворота массива
{
    int[] SomeArray = new int[PrimaryArray.Length];
    int i = 0;
    int j = PrimaryArray.Length - 1;
    while (i < SomeArray.Length)
    {
        SomeArray[i] = PrimaryArray[j];
        i++;
        j = j - 1;
    }
    return SomeArray;
}

int[] PrimaryArray = ArrayFilling(number); //заполним первичный массив
int[] SecondaryArray = GetSecondaryArray(PrimaryArray); //заполним вторичный (развернутый массив) на основе первичного

if (Enumerable.SequenceEqual(SecondaryArray, PrimaryArray)) //сравним два массива и выведем результат
{
    Console.WriteLine($"число {number} является палиндромом");
}
else
{
    Console.WriteLine($"число {number} НЕ является палиндромом");
}