Console.WriteLine("Программа, которая выводит последнюю цифру введенного числа");
// ввести число
Console.WriteLine("Введите желаемое целое число");
int digit = int.Parse(Console.ReadLine()!);

// выведем результат
if (digit < 0) 
{
digit = digit * -1;
Console.Write("Искомое цифра: " + digit % 10);
}
else 
{
   Console.Write("Искомое цифра: " + digit % 10); 
}