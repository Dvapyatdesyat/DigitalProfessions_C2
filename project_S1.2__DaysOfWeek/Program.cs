Console.WriteLine("Программа определения дня недели по его номеру");
// ввести номер дня недели
Console.WriteLine("Введите номер дня недели");
int dayNumber = int.Parse(Console.ReadLine()!);

// проверить выполнение условие

if (dayNumber == 1)
{
    Console.WriteLine("День недели Понедельник");
}
if (dayNumber == 2)
{
    Console.WriteLine("День недели Вторник");
}
if (dayNumber == 3)
{
    Console.WriteLine("День недели Среда");
}
if (dayNumber == 4)
{
    Console.WriteLine("День недели Четверг");
}
if (dayNumber == 5)
{
    Console.WriteLine("День недели Пятница");
}
if (dayNumber == 6)
{
    Console.WriteLine("День недели Суббота");
}
if (dayNumber == 7)
{
    Console.WriteLine("День недели Воскресенье");
}