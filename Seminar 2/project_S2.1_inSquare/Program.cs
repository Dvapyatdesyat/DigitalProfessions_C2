Console.WriteLine("Введите Число №1: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Число №2: ");
int number2 = int.Parse(Console.ReadLine()!);

bool Kvadrat(int number1, int number2)
{
    return number2 == number1 * number1 || number1 == number2 * number2;
}

if (Kvadrat(number1,number2))
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}