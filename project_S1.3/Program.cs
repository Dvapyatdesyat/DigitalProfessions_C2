Console.WriteLine("Программа, которая выводит ряд чисел от [-N;N]");
// ввести число
Console.WriteLine("Введите желаемое число");
int Number = int.Parse(Console.ReadLine()!);

// выведем ряд чисел [-N;N]


if (Number < 0)
{
    Number = Number * -1;
}

int count = Number * -1;

while (count < Number + 1)
{
    Console.Write(count + "," + " ");
    count++;
}