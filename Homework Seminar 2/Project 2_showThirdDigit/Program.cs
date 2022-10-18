int number = new Random().Next(1, 32000);
Console.WriteLine("Generated number: " + number);

int ShowSomeDigit(int number)
{
    int thirdDigit;
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        return thirdDigit = number % 10;
    }
}

if (number>99)
{
Console.WriteLine("Result: " + ShowSomeDigit(number));  
}
else
{
Console.WriteLine("Третьей цифры нет");
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6