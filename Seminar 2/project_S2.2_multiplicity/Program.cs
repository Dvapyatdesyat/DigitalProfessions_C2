Console.WriteLine("Введите Число №1: ");
int number1 = int.Parse(Console.ReadLine()!);


bool Multiplicity(int number1)
{
    if (number1 % 7 == 0 && number1 % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (Multiplicity(number1))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно одному из чисел 7 или 23");
}