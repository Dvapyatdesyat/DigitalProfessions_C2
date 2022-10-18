int number = new Random().Next(100, 1000);
Console.WriteLine("Generated number: " + number);

int ShowSomeDigit(int number)
{
    int secondDigit = (number / 10) % 10;
    return secondDigit;
}

Console.WriteLine("Result: " + ShowSomeDigit(number));

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1