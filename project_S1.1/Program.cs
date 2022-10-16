// написать программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго


Console.WriteLine("Программа проверки квадрата числа");
// ввести числа
Console.WriteLine("Введите число номер 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число номер 2");
int number2 = int.Parse(Console.ReadLine()!);

// проверить выполнение условие
if (number1*number1 == number2)
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else
{
    Console.WriteLine("Число 2 НЕ является квадратом числа 1");
}

