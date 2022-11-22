string BinaryDivision(int n)
{
if (n==0) return "0";
if (n==1) return "1";
int ostatok = n%2;
int del = n/2;
return BinaryDivision(del)+ostatok; // здесь функция вызывает сама себя с входным параметром (del)
}

Console.WriteLine("Введите число для преобразования");
int n = int.Parse(Console.ReadLine()!);
Console.Write(BinaryDivision(n));